require 'spreadsheet'

# Открыть
workbook = Spreadsheet.open 'PersonalInfo.xls'
worksheet = workbook.worksheets[0]

# Подсчет строк
rows = 0
worksheet.rows.each {|row| rows += 1 }
puts "Прочитана #{worksheet.name}. Всего строк #{rows.to_s}"


course = 0
count = 0
if_count = false
groupname = ""

worksheet.each do |row|
	if row[0].nil? then
		if_count = false
		next
	end

	if (row[0].class.to_s == "String") && (row[0].include? "Группа ") then
		puts "#{groupname} : #{(count-2).to_s}" if (course == "1")
		groupname = row[0]
		groupnum = groupname.scan(/\d+/).first
		course = groupnum[1]
		if_count = true
		count = 0
	end

	if if_count then
		count += 1
	end

end

