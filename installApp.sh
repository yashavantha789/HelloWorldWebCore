
sudo killall -9 dotnet
nohup dotnet /home/ec2-user/src/HelloWorldWebCore/build_output/HelloWorldWebCore.dll &>/dev/null &