# coding: utf-8
require 'date'
require "./video_processor"


class VideoServer
	attr_reader :max_parallel_threads, :all_threads, :remain_threads

	#===================================
	#    I N I T I A L I Z E
	#===================================
	def initialize(csv_filename)

		@manager_sleep_time = 10
		@max_parallel_threads = 4
		
		@threads_manager = nil # Менеджер потоков
		@threads_pool = [] # Пул потоков
		@threads_running = [] # Пул работающих потоков

                @locker = Mutex.new
                
		# Метрика
		@remain_threads = 0
		@all_threads = 0
		@server_start_time = Time.now
		@server_started = false

		@video_files_pool = [] # Пул видео файлов
		# Загружаем видео
		self.read_video_files_list csv_filename

	end

	#===================================
	#    S  T  A  R  T
	#===================================
	def start
		return if @server_started
		
		@threads_pool = []

		# Загрузка процессоров для обработки
		@video_files_pool.each do |config|
			@threads_pool << VideoProcessor.new(config)
		end

		# Запускаем менеджер потоков
		@threads_manager = Thread.new { self.threads_manager }

		# Статистика
		@server_started = true
		@all_threads = @threads_pool.size
		@remain_threads = @threads_pool.size
		@server_start_time = Time.now
	end

	#===================================
	#    S  T  O  P
	#===================================
	def stop
		return if not @server_started

		# Убиваем менеджер потоков
        @locker.synchronize {
			@threads_manager.kill
			@threads_manager = nil

			# Убиваем спящие
			@threads_pool.each { |vprocessor| if !vprocessor.nil? then vprocessor.stop end }
			@threads_pool = []

			# Уюиваем запущенные
			@threads_running.each { |vprocessor| if !vprocessor.nil? then vprocessor.stop end }
			@threads_running = []
        }

		# Статистика
		@remain_threads = 0
		@all_threads = 0
		@remain_thread = 0
                @server_started = false
	end
        

	# Читает файл с данными об обрабатываемых файлах
	# Формат файла:
	# ИМЯ_ИСХОДНОГО ; ИМЯ_РЕЗУЛЬТИР ; ВРЕМЯ_НАЧ ; ВРЕМЯ_КОН
	# время дано в формате 00:00:00
	def read_video_files_list(csv_filename)
		@video_files_pool = []
		content = File.open(csv_filename, "r").readlines
		content.each do |line|
			line.chomp!
			splitted = line.split ";"
			@video_files_pool << {
				filename_in: splitted[0], 
				filename_out: splitted[1], 
				time_from: splitted[2], 
				time_to: splitted[3]
			}
		end
	end


	def get_working_time
	    sec = (Time.now.to_i - @server_start_time.to_i).to_s
	    DateTime.strptime(sec,'%s').strftime('%H:%M:%S')
	end

	def get_running_threads_info
	  threads = []
          @locker.synchronize {          
	    @threads_running.each {|thread| threads << {name: thread.to_s, status: thread.nil? ? "offline" : thread.status} }
          }
	  return threads
	end


	def threads_manager
	  # Добавляем новые
      @locker.synchronize {
		if @threads_running.size < @max_parallel_threads then
		  (@max_parallel_threads -  @threads_running.size).abs.times do
                    vprocessor = @threads_pool.shift
                    @threads_running << vprocessor
                    vprocessor.start
                  end
		end
      }

		# Пока где-либо остались задания
		while (@threads_pool.size > 0) || (@threads_running.size > 0) 

              # Спим
	          sleep @manager_sleep_time
              @locker.synchronize {
	 		 	# Удаляем выполненные
		          threads_to_remove = @threads_running.select { |vprocessor| (vprocessor.nil?) || (vprocessor.status == false) }
		          threads_to_remove.each do |vprocessor|
		   		    if( @threads_running.include? vprocessor) then
		              @threads_running.delete vprocessor
		            end
		            @remain_threads -= 1
		              end
			  }

              @locker.synchronize {
		  		# Добавляем новые
		          if @threads_running.size < @max_parallel_threads then
		            (@max_parallel_threads -  @threads_running.size).abs.times do
		                  vprocessor = @threads_pool.shift
		                  @threads_running << vprocessor
		                  vprocessor.start
		            end
				  end
              }
        end        
    end
    
end
