echo Cleaning . . .
sudo docker stop Chores
sudo docker rm Chores
sudo docker rmi tphillips/chores
echo Building . . .
sudo docker build -t tphillips/chores .
echo Running . . .
sudo docker run -d --name Chores -p 5000:5000 tphillips/chores 
