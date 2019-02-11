#!/bin/bash

# Configuration
#------------------------------
USER="USER";
PASS="PASSWORD";
SITE="www.home.ru";
FOLDER="home.ru";
BACKUP_FOLDER="/PATH/TO/BACKUP/DAILY";

# Commands 
#-------------------------------
FIND="$(which find)";
DATE="$(date +'%Y-%m-%d_%H-%M')";
TAR="$(which tar)";
GZIP="$(which gzip)";
WGET="$(which wget)";


# Every 20-th backup to mounthly
if [[ `date +"%d"` -eq 20 ]]; then
  BACKUP_FOLDER="/PATH/TO/BACKUP/MONTHLY";
fi

# Download site
cd /tmp;
rm -rf $SITE;
$WGET -r -l 0 -c -k --user=$USER --password=$PASS ftp://$SITE/$FOLDER;

# Archiving
$TAR cf - $SITE | $GZIP -9 -c > $BACKUP_FOLDER/site_$DATE.tar.gz;
rm -rf $SITE;

# Remove older 1 year archives
$FIND $BACKUP_FOLDER -mtime +365 -exec rm -rf {} \;



