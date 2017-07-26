#!/bin/bash
#Copyright @2017 by Click2Cloud Inc.
clear
echo
source ./serverinfo
echo "Source Server      : $SRC_HOST"
echo "Destination Server : $DEST_HOST"
echo
read -p "Do you wants to create database, Y/n? : " key

        if [ $key == 'Y' -o $key == 'y' ]
            then
                mysql --host=$DEST_HOST --user=DEST_USER --password=DEST_PASSWORD < dbcreate.sql
            fi
                echo "Synchronizing Database : $SRC_DATABASE"
                sleep 2
                echo "..."
                sleep 2
                echo "..."
                sleep 1
                echo
 
mysqldump --host=$SRC_HOST --user=$SRC_USER --password=$SRC_PASSWORD --port=$SRC_PORT --opt "$SRC_DATABASE" | mysql --host=$DEST_HOST --user=$DEST_USER --password=$DEST_PASSWORD --port=$DEST_PORT -C "$DEST_DATABASE"

echo "Process completed."

