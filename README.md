<p align="center">
    <br>
    <a href="https://github.com/LunsfordSpace">
        <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/87952201?s=400&u=5ac30267d7cfc6f11c4ecf57d21c6600941b451f&v=4">
    </a>
    <p align="center">
      ___________________________
    </p>
    <p align="center">
        <a href="https://github.com/lionturtle99">
            <strong>LionTurtle99</strong>
        </a>
    </p>
    <p align="center">
        <a href="https://lionturtle99.github.io/my-portfolio/">
          <img src="https://img.shields.io/badge/-Portfolio-B7178C?loggithub&logoWidth=30">
        </a>
        ¨
        <a href="mailto:<liamthelastson@gmail.com>">
            <img src="https://img.shields.io/badge/-Email%20Me-CA4245?loggithub&logoWidth=30">
        </a>
        ¨
        <a href="https://linkedin.com/in/liameller">
            <img src="https://img.shields.io/badge/-LinkedIn-black.svg?style=plastic&logo=linkedin&colorB=2867B2">
        </a>
    </p>    
</p>

<p align="center">
  <small>Initiated April, 2022</small>
</p>

<h1 align="center">Animal Shelter Api</h1>

#### _An API that functions as a animal shelter website. It utilizes RESTful principles, version control, Cross-Origin Resource Sharing, and Swagger. The user is able to see the in-use version of the API when using Postman._

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

You'll need to open the project in your desired text editor. I recommend [visual studio code.](https://code.visualstudio.com/download).

### ⚙️ Setup and Use

  #### Cloning

  1) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  2) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  3) Clone the repository to your desktop: `$ git clone https://github.com/lionturtle99/AnimalShelterAPI.Solution.git`
  4) Run the command `cd AnimalShelterAPI.Solution` to enter into the project directory.
  5) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Click 'Download ZIP' and extract.
  2) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the AnimalShelterAPI.Solution/AnimalShelterAPI directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=root;pwd=YourPassword;"
  }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to AnimalShelterAPI.Solution/AnimalShelterAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelterAPI.Solution/AnimalShelterAPI`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to AnimalShelterAPI.Solution/AnimalShelterAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelterAPI.Solution/AnimalShelterAPI`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints with the swagger documentation on your browser, or with Postman.

### Using Swagger Documentation 
To explore the AnimalShelter API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

### Note on CORS
CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature, CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS.
For more information or to see how CORS functions, see the [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2#how-cors).

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /{version}/api/{component}
POST /{version}/api/{component}
GET /{version}/api/{component}/{id}
PUT /{version}/api/{component}/{id}
DELETE /{version}/api/{component}/{id}
```

#### Example Query
```
https://localhost:5001/v1/api/Animals?gender=male&minimumAge=55
```

#### Sample JSON Response
```
[
  {
    "animalId": 2,
    "name": "T-Rex",
    "species": "Tyrannosaurus Rex",
    "age": 89,
    "gender": "Male"
  }
]
```

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2022 Liam Eller. All Rights Reserved.

------------------------------

<center><a href="#">Return to Top</a></center>