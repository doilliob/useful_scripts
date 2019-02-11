#!/bin/bash

PATH_TO_BACKUP_DB='/PATH/TO/BACKUP/DB/'
PATH_TO_BACKUP_FILES='/PATH/TO/BACKUP/FILES/'

docker stop redmine_db
docker stop redmine_server
docker rm redmine_db
docker rm redmine_server
docker run -d --name=redmine_db -v $PATH_TO_BACKUP_DB/pg_data:/var/lib/postgresql/data --net=bridge -e POSTGRES_USER=redmine -e POSTGRES_PASSWORD=AbCdEfG -e POSTGRES_DB=redmine postgres;
docker run -d --name=redmine_server -v $PATH_TO_BACKUP_FILES/files:/usr/src/redmine/files -p 3000:3000 -e REDMINE_DB_POSTGRES=redmine_db -e REDMINE_DB_PORT=5432 -e REDMINE_DB_USERNAME=redmine -e REDMINE_DB_PASSWORD=AbCdEfG -e REDMINE_DB_DATABASE=redmine --link redmine_db -h redmine.home.ru redmine;
