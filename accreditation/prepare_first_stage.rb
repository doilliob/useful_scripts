require 'date'
require 'spreadsheet'

=begin
 Название 1 этапа аккредитации.
 :org  - организация 
 :spec - специальность 
 :stage - номер этапа 
 :cam - номер камеры 
 :time_from
 :time_to
 :prefix

 1МГМУ-стом-1э-камера1
=end

#==========================================================
# Возвращает разницу во времени между двумя DateTime в 
# формате HH:MM:SS для отсчета от начала видеофайла
#==========================================================
def datetime_difference(datetime1, datetime2)
	diff = (datetime2.to_time.to_i - datetime1.to_time.to_i).abs
	Time.at(diff).utc.strftime('%H:%M:%S')
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
	# 72-2 | ORG           | 2018   07  12   19   07     34     | 20180712195958 | 81468463.mp4
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
		video_time: video_time
	}
end


#======================================
# ЗАГРУЗКА ФАЙЛОВ 1 ЭТАПА
#======================================
students = {}

xls_files = Dir['xls/1/*.xls']
xls_files.each do |file|
	workbook = Spreadsheet.open file
	worksheet = workbook.worksheets[0]

	worksheet.each 1 do |row|
		next if row[0].nil? 

		filename = row[0]
		spec = row[1]
		splitted = filename.split("_")
		cab = splitted[0].split("-").first
		#------------------------------------------
		video_info = parse_video_time_info filename
		#------------------------------------------
		students_date = video_info[:start_date]
		time_from = row[2].nil? ? video_info[:start_time].strftime('%H:%M:%S') : row[2].strftime('%H:%M:%S')
		time_to = row[3].nil? ? video_info[:end_time].strftime('%H:%M:%S') : row[3].strftime('%H:%M:%S')

		if students[spec].nil? then
			students[spec] = []
		end
	
		students[spec] << {
			students_date: students_date,
			time_from: time_from,
			time_to: time_to,
			cab: cab
		}

	end
end


# Грузим список файлов в базе
video_files = File.open("files.csv","r").readlines

# Для каждой специальности создаем свою обработку
file_out = File.open("convert.csv","w")
students.keys.each do |spec|
	prefix = 1
	students[spec].each do |time_chunk|
		students_date = time_chunk[:students_date]
		time_from = time_chunk[:time_from]
		time_to = time_chunk[:time_to]
		cab = time_chunk[:cab]

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

				out_video_name = "video_out/ORG-#{spec}-1э-камера-#{video_cam}-#{students_date}-#{prefix}.mp4"
				in_video_name = "video_in/#{filename}"

				file_out.puts "#{in_video_name};#{out_video_name};#{out_time_from};#{out_time_to}"

				prefix += 1
=begin
				puts "======================================="
				puts "cab: #{time_chunk[:cab]}"
				puts "file: #{filename}"
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
end
file_out.close
puts "Файл сгенерирован!"

