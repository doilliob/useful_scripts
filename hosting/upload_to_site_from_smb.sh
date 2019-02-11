#!/bin/bash

# Configurations 
#-------------------------------
MNTSRC="//SERVER1/FILES";
MNTDST="/mnt/FILES";
MNTUSER="SMB_USER";
MNTPWD="SMB_PASSWORD";
# FTP
FTPADDR="www.home.ru";
FTPUSER="FTP_USER";
FTPPWD="FTP_PASSWORD";
# Mail
MAILADDR1="admin@home.ru";


# Commands 
#-------------------------------
MOUNT="$(which mount.cifs)";
UMOUNT="$(which umount)";
CURL="$(which curl)";
FIND="$(which find)";
MAIL="$(which mutt)";
MAILRC="/HOME/ME/.muttrc";
ECHO="$(which echo)";


# Mounting
$MOUNT $MNTSRC $MNTDST -o user=$MNTUSER,password=$MNTPWD;

# Uploading
$FIND $MNTDST -type f -name '*.htm' -exec $CURL -T '{}' ftp://$FTPUSER:$FTPPWD@$FTPADDR/ \;

# Unmounting
$UMOUNT $MNTDST;

# Send email
$ECHO "Files uploaded!" | $MAIL -F $MAILRC -s "Uploading files" $MAILADDR1 


