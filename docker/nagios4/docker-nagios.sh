docker run -d --name nagios4 -p 0.0.0.0:8080:80 jasonrivers/nagios:latest
docker cp nagios.cfg nagios4:/opt/nagios/etc/
docker cp hosts.cfg nagios4:/opt/nagios/etc/objects/
docker restart nagios4

