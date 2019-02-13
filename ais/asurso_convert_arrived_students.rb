# Библиотека для работы с XLS файлами
require 'spreadsheet'

#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
# Уже внесенные в АСУ РСО группы
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
added_groups = []
File.open("added.csv").each_line { |line| added_groups << line.chomp; }

#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
# Список студентов по приказу
# Исключаем студентов из вбитых групп
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
arrived_students = []
File.open("students.csv").each_line do |line|
	content = line.chomp.split ";"
	next if added_groups.include? content[0]
	student = { 
		:g => content[0],
		:f => content[1],
		:i => content[2],
		:o => content[3]
	}
	arrived_students << student
end
added_groups = nil

#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
# Читаем XLS'ки заявлений абитуриентов
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
treatements = []

xls_files = Dir["xls/*.xls"]
xls_files.each do |filename|
	workbook = Spreadsheet.open filename
	worksheet = workbook.worksheets[0]

	# С 3 строки XLS'ки (шапка)
	worksheet.each 2 do |row|
		next if row[0].nil?

		treatement = []
		0.upto(27) { |i| treatement << row[i] }
		treatements << treatement
	end
	#puts "==> Загружен файл '#{filename}' "
end

#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
# Ищем зачисленных в заявлениях
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
founded_treatements = []
arrived_students.each do |student|
	
	# ФИО поступившего
	st_f = student[:f].upcase.gsub("'","").gsub(/\s+/,"")
	st_i = student[:i].upcase.gsub("'","").gsub(/\s+/,"")
	st_o = student[:o].upcase.gsub("'","").gsub(/\s+/,"")
	
	# Маски для поиска
	st_mask1 = st_f + st_i + st_o # Полное совпадение
	st_mask2 = st_f[0,st_f.size - 3] + st_i[0,1] + st_o[0,1] # Совпадение Ф(-2 последние буквы) и И(2 буквы) О(2 буквы)
	
	# Найденное заявление
	founded = nil
	treatements.each do |treatement|
		next if treatement[3].nil? || treatement[4].nil? || treatement[5].nil? 
	
		# ФИО из заявления
		tr_f = treatement[3].upcase.gsub("'","").gsub(/\s+/,"")
		tr_i = treatement[4].upcase.gsub("'","").gsub(/\s+/,"")
		tr_o = treatement[5].upcase.gsub("'","").gsub(/\s+/,"")
	
		tr_mask1 = tr_f + tr_i + tr_o
		tr_mask2 = tr_f[0,tr_f.size - 3] + tr_i[0,1] + tr_o[0,1]

		if (tr_mask1 == st_mask1) ||  (tr_mask2 == st_mask2) then
			founded = treatement
			break
		end

	end

	if founded.nil? then
		puts "Не найден студент: #{st_f} #{st_i} #{st_o}"
	else
		founded << student[:g] # добавляем группу студента в данные
		founded_treatements << founded
	end
end
treatements = nil

#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
# Конвертируем найденные заявления 
# в формат АСУ РСО
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
asurso_year = "2018"
asurso_year_prefix = "18"
asurso_order_num = "496у"
asurso_order_date = "15.08.2018"
asurso_order_begin = "15.08.2018"

asurso_students = []

founded_treatements.each do |statement|
	asurso = []
	0.upto(47) {|i| asurso[i] = ""}

	# %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
	# Заполняем студента
	# %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

	# %%%%%%%%%%%%%%%%%%%%%%%
	# АСУ РСО
	# %%%%%%%%%%%%%%%%%%%%%%%
	# 0 Фамилия //+
	asurso[0] = statement[3].chomp.gsub(/\'/,"").gsub(/\s+/,"")
	
	# 1 Имя //+
	asurso[1] = statement[4].chomp.gsub(/\'/,"").gsub(/\s+/,"") 
	
	# 2 Отчество
	asurso[2] = statement[5].chomp.gsub(/\'/,"").gsub(/\s+/,"") 
	
	# 3 Дата рождения//+
	asurso[3] = statement[18].nil? ? "1999-03-12" : statement[18]
	if asurso[3].to_s.include? "-" then
		tmp = asurso[3].to_s.split("-")
		asurso[3] = tmp[2] + "." + tmp[1] + "." + tmp[0]
	end
	
	# 4 Пол//+
	asurso[4] = (statement[6].nil? || (statement[6] == "")) ? "Женский" : statement[6]
	
	# 5 СНИЛС
	# 6 Адрес регистрации по месту пребывания
	# 7 Финансирование //+
	asurso[7] = (statement[2].include? "договор") ? "За счет физического лица" : "За счет федерального бюджета"
	
	# 8 Группа //+
	asurso[8] = statement[28] + asurso_year_prefix
	
	# 9 № приказа //+
	asurso[9] = asurso_order_num
	
	# 10 Дата приказа //+
	asurso[10] = asurso_order_date
	
	# 11 Действует с //+
	asurso[11] = asurso_order_begin
	
	# 12 Причина //+
	asurso[12] = "По среднему баллу аттестата"
	
	# 13 Гражданство
	# 14 Категория здоровья
	# 15 Инвалидность
	# 16 Группа здоровья
	# 17 Физкультурная группа
	# 18 Наличие потребности в адаптированной программе обучения
	# 19 Наличие потребности в длительном лечении
	# 20 Образование //+
	case statement[20]
	when "Аттестат о среднем (полном) общем образовании"
		asurso[20] = "Среднее общее образование"
	when "Аттестат об основном общем образовании"
		asurso[20] = "Основное общее образование"
	when "Диплом о среднем проф образовании"
		asurso[20] = "СПО по программам подготовки специалистов среднего звена"
	#when "Диплом о высшем профессиональном образовании"
	#	education = ""
	#when "Диплом о начальном профессиональном образовании"
	#	education = ""
	#when "Диплом о неполном высшем проф. образовании"
	#	education = ""
	#when "Академическая справка"
	#	education = ""
	else
		asurso[20] = "Среднее общее образование"
	end
	
	# 21 Дата окончания предыдущего обучения //+
	asurso[21] = (statement[24].nil? || (statement[24] == "")) ? "2018-06-25" : statement[24]
	if asurso[21].to_s.include? "-" then
		tmp = asurso[21].to_s.split("-")
		asurso[21] = tmp[2] + "." + tmp[1] + "." + tmp[0]
	end
	#------------------------------------------CAT
	if asurso[21] == "26.062018" then
		asurso[21] = "26.06.2018"
	end
	#--------------------------------------------

	# 22 Закончил специальную организацию для учащихся с ОВЗ //+
	asurso[22] = "Нет"
	
	# 23 Обучается по международному договору //+
	asurso[23] = "Нет"
	
	# 24 Средний балл
	# 25 Льгота
	# 26 Телефон
	# 27 Email
	# 28 Дополнительная информация
	# 29 Адрес проживания //+
	asurso[29] = statement[9].nil? ? "г.Самара, ул.Ставропольская,д.218а, кв.341" : statement[9].gsub(/\;/," ")
	
	# 30 Тип документа //+
	case statement[11]
	when "Паспорт гражданина РФ"
		asurso[30] = "Паспорт РФ"
	when "Паспорт гражданина иностранного государства"
		asurso[30] = "Иностранный паспорт"
	when "Свидетельство о рождении"
		asurso[30] = "Свид-во о рождении"
	else
		asurso[30] = "Паспорт РФ"
	end
	
	# 31 Серия паспорта
	asurso[31] = statement[13].nil? ? "" : statement[13]
	
	# 32 Номер паспорта //+
	asurso[32] = statement[14].nil? ? "" : statement[14]
	
	# 33 Дата выдачи паспорта //+
	asurso[33] = statement[17].nil? ? "" : statement[17]
	if asurso[33].to_s.include? "-" then
		tmp = asurso[33].to_s.split("-")
		asurso[33] = tmp[2] + "." + tmp[1] + "." + tmp[0]
	end

	# 34 Кем выдан паспорт //+
	asurso[34] = statement[16].nil? ? "" : statement[16]

	# 35 Код подразделения
	asurso[35] =  statement[15].nil? ? "613-1" : statement[15]

	# 36 Место рождения //+
	asurso[36] = statement[19].nil? ? "" : statement[19]

	# 37 Адрес регистрации //+
	asurso[37] = statement[9].nil? ? "г.Самара, ул.Ставропольская,д.218а, кв.341" : statement[9].gsub(/\;/," ")

	# 38 Воинское звание
	# 39 Военно-учётная cпециальность
	# 40 Годность к военной службе
	# 41 Группа воинского учёта
	# 42 Категория запаса
	# 43 Номер военного билета
	# 44 Состав
	# 45 Наименование отдела ОВК
	# 46 Военная подготовка
	# 47 Стоит на специальном учёте
	
	# %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
	# Если иноcтранный гражданин, то удаляем данные 
	# удост документа
	# %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
	pass_type = asurso[30]
	pass_ser = asurso[31]
	pass_num = asurso[32]
	pass_when = asurso[33]
	pass_who = asurso[34]
	pass_code = asurso[35]
	pass_birth = asurso[36]
	pass_addr = asurso[37]

	def clean_asurso_pass_data(asurso)
		29.upto(37) { |i| asurso[i] = "" }
	end

	if (pass_type == "Паспорт РФ") &&
	   ((pass_ser == "") ||
		(pass_num == "") ||
		(pass_when == "") ||
		(pass_who == "") ||
		(pass_birth == "") ||
		(pass_addr == "")) then

	   clean_asurso_pass_data asurso
	end

	if (pass_type == "Паспорт РФ") &&
	   (pass_ser.size != 4) then

	   clean_asurso_pass_data asurso
	end

	if (pass_type == "Иностранный паспорт") &&
	   ((pass_num == "") || (pass_who == "")) then

		clean_asurso_pass_data asurso
	end
	
	# %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

	asurso_students << asurso
end


#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
# Выводим данные в выходной файл
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
puts "Запись файла CSV (UTF8)"
File.open("out_utf8.csv","w:UTF-8") do |asurso_file|
	asurso_students.each { |student| asurso_file.puts (student.join ";") }
end

puts "Запись файла CSV (CP1251)"
File.open("out_cp1251.csv","w:CP1251") do |asurso_file|
	asurso_students.each { |student| asurso_file.puts (student.join ";") }
end
