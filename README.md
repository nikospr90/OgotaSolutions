# ÖgötaSolutions
To start the project you will need :
- Visual Studio Code for the client side of the project.
- Visual Studio Community for the server side of the project.
(All the necessary files are located in the folder "ÖgötaSolutions"!)

Step by step start up:
- Open VScode terminal or Visual Studio Community terminal or any terminal of your choice.
- In the terminal navigate to the folder "ÖgötaSolutions/client".
- From there enter the command "npm run dev" and press enter.
- Amongst other info that comes to the terminal, locate the "http://local/xxxx" link.
- Press Ctr + click on that link.
- Your browser should open now with the home page of the project.
  
** Warning, It might be necessery to run the command "npm install" to install missing or outdated dependencies before run the command.


# About this project
This Project is divided in two parts
- The server side part that handles the API calls and is responsible for the data models.
- The client side part that handles the frontend that prompts the API calls and displays the data.

- The server side is build on ASP.NET Core i C#. 
  It will include model classes that will build the coresponding tables in the database.
  It wiil also include services that handle the API calls.

- The client side is build in Vite-React and uses Javascript.
  It will include modules/components that will handles the data display from the server side.

- The database that will host the projects data is SQLite.
**More info about API calls and specification will come in the future.
