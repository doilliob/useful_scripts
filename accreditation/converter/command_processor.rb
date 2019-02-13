# coding: utf-8
require "./video_server"

class CommandProcessor
	
	def initialize
		@server = VideoServer.new 'convert.csv'
	end

	def start
		thread = Thread.new { self.process	}
		thread.join
	end

	def process
		200.times {puts}
		
		str = ""
		while str != "exit"
			puts	
			puts "Введите команду: start/stop, ls, time, clear, exit =>"
			str = gets.chomp
			200.times {puts}

			if str == "start" then
				@server.start
			end

			if str == "stop" then 
				@server.stop
			end

			if str == "time" then
				puts
				puts "Время выполнения сервера: #{@server.get_working_time}"
				puts
			end

			if str == "ls" then
				max = @server.max_parallel_threads
				all = @server.all_threads
				remain = @server.remain_threads
				threads = @server.get_running_threads_info
                                percent = (all == 0) ? 0 : (all - remain)*100/all

				counter = 1
				puts "№\tИмя\t\t\t\t\tСтатус"
				threads.each { |thread| puts "#{counter}.\t#{thread[:name]}\t#{thread[:status]}" ; counter += 1 }
				puts
				puts "Время работы #{@server.get_working_time}"
                                puts "Выполнение: #{all - remain} из #{all} (#{ format('%.0f%', percent) })"
                                puts "Осталось: #{remain}"
				puts "Макс. одновременных потоков: #{max}"

			end

			if str == "clear" then
				200.times {puts}
			end
		end
		
	end
end
