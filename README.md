# rest-api-demo-angular-net-core

Quick demo for an API using netcore in the backend and angular in the frontend

Three APIs are called in the backend after entering two numbers in the UI

1st API sums the two numbers and saves the data to a SQL server DB

2nd API receives a number and multiply it by 2  and saves the data to a SQL server DB

3rd API receives a number x, and calculates x to the power of 2  and saves the data to a SQL server DB

From UI you enter two numbers and then a button calls the first API takes the result and calls the second API then gets the result and calls the 3rd API

you need to create a local database in SQL server called [demo-rest-api]

then also inside folder sql scripts run the script to create a table calles results
