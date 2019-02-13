require 'date'

const_dt = DateTime.parse("2018-10-01 00:00:00+04:00")

src_dt = DateTime.parse("2018-10-24 12:03:01+04:00")
src_time = "01:01:01"


src_time_to_date = DateTime.parse("2018-10-01 #{src_time}+04:00")
differ_src_const_time_sec = src_time_to_date.to_time.to_i - const_dt.to_time.to_i

abs_sec = src_dt.to_time.to_i + differ_src_const_time_sec
result_dt = DateTime.strptime( abs_sec.to_s, '%s').strftime('%H:%M:%S')


puts "CONST: #{const_dt}"
puts "IN_DT: #{src_time_to_date}"
puts "DIFF_SC: #{differ_src_const_time_sec}"
puts "DIFF_MIN: #{differ_src_const_time_sec/60.0}"
puts "DIFF_HR: #{differ_src_const_time_sec/60.0/60.0}"

puts "----------------------------"

result_dt = DateTime.parse(Time.at(abs_sec).to_s)
puts "#{result_dt}"