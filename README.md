This SQL Tester tool is created for making the daily job eaiser for our team. As a Data Intergation Specialist & SQL Developer for integrating various EPR databases with our MySQL database, our daily responsibility involves writing sql script and testing sql script in  external client's server. For some ERP's database like Sage300, there is no tool or interface like SSMS or SQLYog that we can use to query their database directly. Before I created this tool, we had to use Excel to connect to ODBC, and then query the database. The problem with Excel is that it is slow, and some old version of Excel is difficult to use. A lot of time, we spent 2/3 time figurating out how to use different version of Excel instead of actually testing the sql code.

With this SQL Tester, we can easily connect to client's database through ODBC, and get the data returned in a human readable format.

## Where to open this app
- Clone down this repo
- Navigate to builds/ directory
- Open either 32 or 64 version of the app based on the OBDC you set up. (If the ODBC you set up is 32bit, then you have to use 32 application. If ODBC is 64bit, then you will need to use 64 version)

## How to use this app
1. Open up the app, fill in the connection info and click "Next" to go to next tab.

![Connection Page](https://raw.githubusercontent.com/jeffreychen2016/SQLTester/master/imgs/SQLTester1.PNG)

2. Click on "Next" button after you fill up the connetion info.