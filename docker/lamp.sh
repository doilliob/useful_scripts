#!/bin/bash


PATH_TO_BACKUP_FILES='/PATH/TO/BACKUP/FILES/'
docker run -d --name=httpd_app_1 -p "8888:80" -v $PATH_TO_BACKUP_FILES:/app mattrayner/lamp:latest-1604-php7
