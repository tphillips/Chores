echo Cleaning . . .
sudo docker stop Chores
sudo docker rm Chores
sudo docker rmi tphillips/Chores
echo Building . . .
sudo docker build -t tphillips/chores .
echo Running . . .
sudo docker run --name Chores -p 5000:5000 -t -i tphillips/chores /bin/bash
