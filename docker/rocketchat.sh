#!/bin/bash

PATH_TO_BACKUP_DB='/PATH/TO/BACKUP/DB/'

docker stop rocketchat_db
docker stop rocketchat_server
docker rm rocketchat_db
docker rm rocketchat_server

docker run --name rocketchat_db -v $PATH_TO_BACKUP_DB:/data/db -d mongo:3.2 mongod --smallfiles
docker run --name rocketchat_server --env ROOT_URL=http://chat.home.ru:4444 -p 4444:3000 --link rocketchat_db:db -h chat.home.ru -d rocket.chat 
