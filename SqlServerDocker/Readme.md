## Timestamp
43:34

## Video URL
https://www.youtube.com/watch?v=Yj69cWEG_Yo&t=1307s&ab_channel=IAmTimCorey

## Commands
* docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Pwd12345!" -p 11433:1433 -d mcr.microsoft.com/mssql/server:2017-latest
* localhost,11433 (in Management Studio)
* docker run -p 11433:1433 -d restored-db
* docker system prune -f
* docker build -t restored-db:1.0.1 .
* docker run -p 11433:1433 -d restored-db:1.0.1

## Notes
Redgate Data Masker