function list_child_processes () {
    local ppid=$1;
    local current_children=$(pgrep -P $ppid);
    local local_child;
    if [ $? -eq 0 ];
    then
        for current_child in $current_children
        do
          local_child=$current_child;
          list_child_processes $local_child;
          echo $local_child;
        done;
    else
      return 0;
    fi;
}

ps 77950;
while [ $? -eq 0 ];
do
  sleep 1;
  ps 77950 > /dev/null;
done;

for child in $(list_child_processes 77985);
do
  echo killing $child;
  kill -s KILL $child;
done;
rm /Users/lesliesalguero/Desktop/dot_net_core_ex/bin/Debug/net7.0/6ce33698f34c437c8bc4bab8d5690951.sh;
