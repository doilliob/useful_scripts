#!/bin/bash

# Configuration
DEST="/PATH/TO/SAVE/"
SRC="/DATA/TO/SAVE/"

# Commands
TAR="$(which tar)"
GZIP="$(which gzip)"
NOW="$(date +"%Y%m%d")"
FILE="$DEST/$NOW.tgz"
LOG="$(which logger)"

$LOG Archiving...

# Archiving
cd $SRC
$TAR cpf - . | $GZIP -9 -c > $FILE

$LOG Remove old files...

# check if files > 1 month
FNUM="$(find $DEST/* | wc -l)"
if [ $FNUM -ge 30 ] ; then
   find $DEST/* -type f -mtime +31 -exec rm -rf {} \;
fi
