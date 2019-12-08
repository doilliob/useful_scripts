import requests
from lxml import html
import re
import wget
import os
import os.path

podcast_num = ''
podcasts = ['676']

def download_and_cat_files(podcast_num):
	main_url = 'https://radio-t.com'

	print(' --> Обрабатываем страницу архивов подкастов')
	'''
	Получаем содержимое Архива с Радио-Т
	'''
	content = requests.get("%s/archives/" % main_url).text
	'''
	Парсим HTML архива выпусков
	'''
	blocks = html.fromstring(content).cssselect('div.blog-archives-post')

	def find_needed(block):
		el = block.cssselect('h3 > a > span.podcast-title-number');
		el_type = block.cssselect('a.category');
		return (len(el) > 0) and (el.pop().text == podcast_num) and (len(el_type) > 0) and (el_type.pop().text == '#podcast')

	elem = list(filter(find_needed, blocks))
	if len(elem) != 1:
		print('Элемент не найден!')
		exit(0)

	link = main_url + elem.pop().cssselect('h3.number-title > a').pop().get('href')

	'''
	Парсим HTML выпуска
	'''
	print(' --> Обрабатываем страницу подкаста')
	content = requests.get(link).text
	block = html.fromstring(content).cssselect('div.post-podcast-content').pop()

	''' Парсим тайминги '''
	print('    => Получаем тайминги')
	timings = []
	timing_blocks = block.cssselect('ul > li')
	for time_blk in timing_blocks:
		time = time_blk.cssselect('em').pop().text
		text = time_blk.cssselect('a').pop().text
		timings.append({ 'start': time, 'title': text})

	''' Добавляем тайминги конца записи '''
	timings = [{'start': '00:00:00', 'title': 'Вступление'}] + timings
	for i in range(0, len(timings) - 1):
		timings[i]['end'] = timings[i+1]['start']


	''' Получаем ссылку на mp3 '''
	print('    => Получаем ссылку на mp3')
	mp3_link = block.cssselect('p > a')[0].get('href')
	mp3_filename = re.split(r'/', mp3_link)[-1]

	''' Скачиваем файл MP3 '''
	if not(os.path.isfile(mp3_filename)):
		print('    => Скачиваем mp3')
		wget.download(mp3_link, mp3_filename)


	''' Режем MP3 по таймингам '''
	mp3_dir = "Радио-Т %s" % podcast_num
	os.mkdir(mp3_dir)
	num = 1
	for time in timings:
		number = num if (num > 9) else "0%s" % num
		title = time['title']
		start = " -ss %s " % time['start']
		end = (" -to %s " % time['end']) if ('end' in time) else ''
		meta = ' -metadata title="%s" ' % time['title']
		filename_out = '%s/%s. %s.mp3' % (mp3_dir, number, title)
		filename_out = re.sub(r'[\?,\!,\$]', '', filename_out)
		command = 'C:/opt/cmder/bin/ffmpeg.exe -i "%s" -c:a copy -y %s %s %s "%s" ' % (mp3_filename, start, end, meta, filename_out)
		print('=======================================')
		print(command)
		print('=======================================')
		os.system(command)
		num += 1



if __name__ == '__main__':
	for num in podcasts:
		download_and_cat_files(num)
