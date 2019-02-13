require 'date'
require 'spreadsheet'


=begin
 Название 2 этапа аккредитации.
 org: - организация
 spec: - специальность
 guid: - ID
 nav: - наименвание навыка (практич_навыки)
 cep: - номер цепочки (Ц1)
 station: - номер станции (С - по камерам 1-8)
 cam: - номер камеры (1-2)
 :time_from
 :time_to
 :prefix

 1МГМУ-стом-87238572-анестезия-Ц1-С1-К1
=end



#==========================================================
# Возвращает разницу во времени между двумя DateTime в 
# формате HH:MM:SS для отсчета от начала видеофайла
#==========================================================
def datetime_difference(datetime1, datetime2)
	diff = (datetime2.to_time.to_i - datetime1.to_time.to_i).abs
	Time.at(diff).utc.strftime('%H:%M:%S')
end


#===========================================================
# Получает начало видеофайла(относительно начала дня) и время 
# метки в файле (00:00:00),а возвращает абсолютное 
# (DateTime//00:00:00) значение метки относительно начала дня
#===========================================================
def datetime_absolute_time(datetime1, vtime)
	sec = DateTime.parse("2018-10-01 #{vtime}+04:00").to_time.to_i - DateTime.parse("2018-10-01 00:00:00+04:00").to_time.to_i
	abs_sec = datetime1.to_time.to_i + sec
	DateTime.parse( Time.at(abs_sec).to_s ).strftime('%H:%M:%S')
end

def datetime_absolute(datetime1, vtime)
	sec = DateTime.parse("2018-10-01 #{vtime}+04:00").to_time.to_i - DateTime.parse("2018-10-01 00:00:00+04:00").to_time.to_i
	abs_sec = datetime1.to_time.to_i + sec
	DateTime.parse( Time.at(abs_sec).to_s )
end



#==========================================================
# Возвращает информацию о тайминге видеофайла по его имени
#==========================================================
# 72-2_ORG_20180712190734_20180712195958_81468463.mp4
def parse_video_time_info(filename)
	splitted = filename.split("_")
	#================================
	# определение длительности файла
	#================================
	#   0         1             2  0-3  4-5  6-7  8-9  10-11  12-13        3               4
	# 72-2 | ORG                | 2018   07  12   19   07     34     | 20180712195958 | 81468463.mp4
	str_date = splitted[2]
	date1 = [ str_date[6..7], str_date[4..5], str_date[0..3] ].join "."
	time1 = [ str_date[8..9], str_date[10..11], str_date[12..13] ].join ":"
	start_time = DateTime.parse("#{date1} #{time1}+04:00")

	str_date = splitted[3]
	date2 = [ str_date[6..7], str_date[4..5], str_date[0..3] ].join "."
	time2 = [ str_date[8..9], str_date[10..11], str_date[12..13] ].join ":"
	end_time = DateTime.parse("#{date2} #{time2}+04:00")

	video_time = datetime_difference(start_time, end_time)
	return {
		start_date: date1,
		start_time: start_time,
		end_date: date2,
		end_time: end_time,
		video_time: video_time,
		cab: splitted[0].split("-").first
	}
end



#======================================
# ЗАГРУЗКА ФАЙЛОВ 2 ЭТАПА
#======================================
students = []

xls_files = Dir['xls/2/*.xls']
xls_files.each do |file|
	workbook = Spreadsheet.open file
	worksheet = workbook.worksheets[0]

 	last_guid = ""
	worksheet.each 1 do |row|
		next if row[0].nil? 
		filename = row[0]
		
		guid = row[5]
		# Есть объединенные ячейки GUID
		if guid.nil? && file=='xls/2/2_1.xls' then
			guid = last_guid
		end
		last_guid = guid

		#-------------------------------------------
		video_info = parse_video_time_info filename
		#-------------------------------------------
		# Абсолютное время начала врагмента относительно начала дня
		students_date = video_info[:start_date]
		time_from = datetime_absolute( video_info[:start_time], row[3].strftime('%H:%M:%S')).strftime('%H:%M:%S')
		time_to   = datetime_absolute( video_info[:start_time], row[4].strftime('%H:%M:%S')).strftime('%H:%M:%S')
		cab = video_info[:cab]

		students << {
			students_date: students_date,
			time_from: time_from,
			time_to: time_to,
			guid: guid,
			cab: cab
		}
	end
end


#======================================
# ЗАПОЛНЯЕМ НЕРАСПРЕДЕЛЕННЫЕ GUID
#======================================
# Получаем список guid - студентов
students_guids = {}

xls_files = Dir['xls/students/*.XLS']
xls_files.each do |file|
	workbook = Spreadsheet.open file
	worksheet = workbook.worksheets[0]

	worksheet.each 4 do |row|
		next if (row[0].nil? || row[4].nil?)
		# Из имени файла получаем специальность
		students_guids[row[4].chomp] = file.split('/').last.split(' ').first
	end
end


# Убираем дублирующихся студентов в разных кабинктах
cabs = {}
# Собираем хэш "студент -> кабинет"
students.each do |e| 
	if cabs[e[:guid]].nil? && !e[:guid].nil? then
		cabs[e[:guid]] = e[:cab]  
	end
end

not_in_his_cab = students.select {|e| cabs.has_key?(e[:guid]) && (cabs[e[:guid]] != e[:cab]) }
puts "Убираем дублирующихся студентов в разных кабинетах: #{not_in_his_cab.size.to_s}"
#puts not_in_his_cab.size.to_s
#not_in_his_cab.each { |e| puts "#{e[:guid]} вместо #{e[:cab]} должен быть в #{cabs[e[:guid]]}" }
not_in_his_cab.each { |e| e[:guid] = nil }
#not_in_his_cab = students.select {|e| cabs.has_key?(e[:guid]) && (cabs[e[:guid]] != e[:cab]) }
#puts not_in_his_cab.size.to_s

 

# Отбираем с заполненными guid
all_guids = students.select { |elem| !elem[:guid].nil? } 
# Делаем список из guid
all_guids = all_guids.map { |elem| elem[:guid] } 
# Список guid не внесенных в расчасовку
all_guids = students_guids.keys.select { |elem| !(all_guids.include? elem) } 

puts "Всего: #{students.size}"
puts "Не занесено #{all_guids.size}"
puts "Пустые guid в расчасовке #{(students.select { |elem| elem[:guid].nil? }).size}"
puts "Распределяем..."

null_guids = students.select { |elem| elem[:guid].nil? }
null_guids.each { |student| student[:guid] = all_guids.pop }

puts "Осталось после распределения #{all_guids.size}"
null_guids = students.select { |elem| elem[:guid].nil? }
puts "Не занесено #{null_guids.size}"

puts "Удаляем незанесенных из обработки..."
null_guids.each { |elem| students.delete elem }
puts "Всего: #{students.size}"



#======================================
# ГЕНЕРАЦИЯ ВИДЕОФАЙЛА
#======================================

# Грузим список файлов в базе
video_files = File.open("files.csv","r").readlines

# Для каждой специальности создаем свою обработку
file_out = File.open("convert.csv","w")

prefix = 1
students.each do |time_chunk|
	spec = students_guids[time_chunk[:guid]]
	students_date = time_chunk[:students_date]
	time_from = time_chunk[:time_from]
	time_to = time_chunk[:time_to]
	cab = time_chunk[:cab]
	guid = time_chunk[:guid].gsub("student_","")

	# Время начала и конца фрагмента в DateTime для сравнения времени
	chunk_start = DateTime.parse("#{students_date} #{time_from}+04:00")
	chunk_end = DateTime.parse("#{students_date} #{time_to}+04:00")
	
	# смотрим каждое вхождение кусочка в видеофайлы
	video_files.each do |filename|
		filename.chomp!
		
		splitted = filename.split("_")
		video_cab = splitted[0].split("-").first
		video_cam = splitted[0].split("-")[1]
		#------------------------------------------
		video_info = parse_video_time_info filename
		#------------------------------------------
		
		# Выходим если не тот кабинет или дата
		next if ((video_cab != cab) || (video_info[:start_date] != students_date))
		
		video_start = video_info[:start_time]
		video_end = video_info[:end_time]

		# Определяем, входит ли кусочек в видеофайл
		if ((chunk_start > video_start) && (chunk_start < video_end)) ||
		   ((chunk_end > video_start)   && (chunk_end < video_end))      
		then		
			# если кусочек входит в видео частично, то надо считать
			# либо с начала видеофайла
			out_time_from = (chunk_start < video_start) ? video_start : chunk_start
			out_time_to = (chunk_end > video_end) ? video_end : chunk_end

			abs_from = out_time_from
			abs_to = out_time_to

			# Переводим время в формат относительно начала файла
			out_time_from = datetime_difference(out_time_from, video_start)
			out_time_to = datetime_difference(out_time_to, video_start)


				stations = %w(43 44 45 48 60 61 72)
			out_video_name = "video_out/ORG-#{spec}-#{guid}-практич_навыки-Ц1-С#{((stations.index cab) + 1).to_s}-К#{video_cam}-#{students_date}-#{prefix}.mp4"
			in_video_name = "video_in/#{filename}"

			file_out.puts "#{in_video_name};#{out_video_name};#{out_time_from};#{out_time_to}"

			prefix += 1
=begin
			puts "======================================="
			puts "cab: #{time_chunk[:cab]}"
			puts "file: #{filename}"
			puts "fileout: #{out_video_name}"
			puts "duration: #{video_info[:video_time]}"
			puts "video start/end: #{video_start.strftime('%H:%M:%S')}/#{video_end.strftime('%H:%M:%S')}"
			puts "chunk start/end: #{chunk_start.strftime('%H:%M:%S')}/#{chunk_end.strftime('%H:%M:%S')}"
			puts "chunk duration: #{datetime_difference(chunk_start,chunk_end)}"
			puts "v-resul s/e: #{abs_from.strftime('%H:%M:%S')}/#{abs_to.strftime('%H:%M:%S')}"
			puts "v-resul int: #{out_time_from}/#{out_time_to}"
			puts "======================================="
			puts
=end
		end

	end
end

file_out.close
puts "Файл сгенерирован!"


