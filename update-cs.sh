echo "Updating connection string"
echo
read -p "Please provide MySQL Server Host : " host
#read -p "Please provide MySQL Server Port : " port
#read -p "Please provide MySQL Server DB : " db
#read -p "Please provide MySQL Server User : " user
#read -p "Please provide MySQL Server Password : " password
export MYSQL_SERVICE_HOST="$host"
export MYSQL_SERVICE_PORT=3306
export MYSQL_DATABASE=cardb
export MYSQL_USER=c2cadmin
export MYSQL_PASSWORD=Newuser#123
echo
echo "Connection string updated successfully."
