# RefTool WebApp

RefTool is a simple web app for basketball referees to use at scorer's table. It provides a user interface designed to comfortably run statistics for a basketball game. It's compact by design to provide a simple alternative for official apps used in professional leagues such as GeniusSports' FIBA LiveStats. At the same time to comes with all the necessary options to generate a full match report and notification service to make sure rules regarding fouls etc are properly applied.

It has also become a subject of research in my engineer's thesis. It's created in **Blazor** - a relatively new framework for creating web applications, which combines various interesting architecture approaches. The simple application that I provided serves as a starting point to a conversation about Blazor's versatility, future and how it compares to other popular frameworks and libraries.

### Installation

To successfully run this application, you'll need:
- .NET in version 5 or higher
- SQL Server in version 2018 or higher

Installation process:
1. Clone this repo.
2. Go to repo directory on your local machine.
3. Initialize database using provided SQL script by running

		sqlcmd -S <your_server_name> -i initialize-reftool.sql
4. Modify file appsettings.json so the ConnectionString has settings for your environment. In Data Source section put your server name, in Initial Catalog put the name of the database (reftool by default).
5. Run command

		dotnet run
		
![gameview](https://user-images.githubusercontent.com/19887441/131915687-0a33e59c-74d7-40b7-ae06-8f1b40b12abe.PNG)
