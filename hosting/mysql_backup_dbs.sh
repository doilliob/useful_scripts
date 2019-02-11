#!/bin/bash

# Configuration
MyUSER="USER"
MyPASS="PASSWORD"
MyHOST="HOST"
DEST="/PATH/TO/SAVE/"

# Commands
MYSQL="$(which mysql)"
MYSQLDUMP="$(which mysqldump)"
CHOWN="$(which chown)"
CHMOD="$(which chmod)"
GZIP="$(which gzip)"
HOST="$(hostname)"
NOW="$(date +"%Y%m%d")"
LOG="$(which logger)"
MBD="$DEST"

FILE=""
DBS=""
 
# DO NOT BACKUP these databases, delemiter SPACE
IGN="information_schema performance_schema mysql"

# Get all database list first
DBS="$($MYSQL -u $MyUSER -h $MyHOST -p$MyPASS -Bse 'show databases')"

for db in $DBS
do
    $LOG Archiving Db [$db]
    skipdb=-1
    if [ "$IGN" != "" ]; then
    for i in $IGN
    do
      [ "$db" == "$i" ] && skipdb=1 || :
    done
    fi
 
    if [ "$skipdb" == "-1" ] ; then
    MBD="$DEST/$db"    	
    [ ! -d $MBD ] && mkdir -p $MBD || :
    FILE="$MBD/$NOW.sql.gz"
    echo $db;
    $MYSQLDUMP --add-drop-table --opt -u $MyUSER -h $MyHOST -p$MyPASS $db | $GZIP -9 > $FILE
    $LOG Deleting old dbs
    FNUM="$(find $MBD/* | wc -l)"
    if [ $FNUM -ge 30 ] ; then
      find $MBD/* -type f -mtime +30 -exec rm -rf {} \;
    fi
    fi

done;

