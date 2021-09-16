# JAP_TASK_2

This is version 2 of the backend repository for a movie rating app - MovieBuff similair to IMDB but much simpler. Main technology used for development is .NET 5.

## Setup instructions

1. Clone this repository to your local machine
2. Make sure you have SQL Server set up. If you own a database with the name **movies-web-api** then make sure to change the name of this project's databse by going to **appsettings.json** and changing the **ConnectionStrings'** **DefaultConnection** value.
3. run `dotnet ef database update` in the terminal to create the database
4. run `dotnet watch run -p .\JAP_TASK_2\` to start the web api

## Functionalities (v2 only)

- Reporting endpoints that include **Top 10 movies with the most ratings**, **Top 10 movies with the most screenings** and **Movies with the most sold tickets**
- Endpoint for buying tickets for selected screenings
- NUnit tests that cover above mentioned endpoints
