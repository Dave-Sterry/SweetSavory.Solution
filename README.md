# Dr Sillystringz's Factory
<div align="center">
<img src="https://github.com/Dave-Sterry.png" width="200px" height="auto">
</div>

### A C# website by David Sterry 
Initialized on 01/08/21
Last updated on 01/008/21


## **Project Description**

This website allows the manager of a Sillystring factor to manage their machines and engineers. Machines and enigneers can be added seperately, and then assigned to each other. This was a Friday independent project for Epicodus to further my knowledge of using MySQL, join tables and many to many relationships along with CRUD functionality.  

## **User Stories**
* As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
* As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
* As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
* As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed
* As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
* I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.



## **Required for Use**
* C# and .Net Core installed on your local machine. Download .Net Core [Here](https://dotnet.microsoft.com/download) Follow the instructions to install on your machine
* Console/Terminal access.
* Code Editor like VSCode download [Here](https://code.visualstudio.com/) Follow the instructions to install on your machine
* MySQL Community Server download [Here](https://dev.mysql.com/downloads/mysql/) Follow the instructions to install on your machine
* MySQL Workbench [Here](https://www.mysql.com/products/workbench/) Follow the instructions to install on your machine
* An internet browser of your choice; I prefer Chrome


## **How to get this project** 

### Download from Github:
1. Use the browser navigate to my GitHub page [respository](https://github.com/Dave-Sterry/Factory.Solution)
2. Click the Green **Code** button and select **Download Zip**

### Alternatively clone from Github via Gitbash:
1. In your terminal, navigate to the folder where you would like to clone the project too
2. Clone this repo to your chosen folder using "git clone https://github.com/Dave-Sterry/Factory.Solution in terminal


## **Installation Instructions**
### **Setup Database Connection**

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the main `Factory` directory. 
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=david_sterry;uid=YourId;pwd=YourPassword;"
  }
}
```
* Update the Server, Port, and User ID as needed with your own

Import Database using Entity Framework Core
* Navigate to UniversityRegistrar.Solution/UniversityTracker and type `dotnet ef migrations add <MigrationName>` into the terminal
* Then, type `dotnet ef database update` into the terminal to create your database tables.


## **SQL Schema**

DB SQL Schema Snippet
* Paste this Schema Create Statement into your SQL Workbench to create this database and its tables.
```
CREATE DATABASE  IF NOT EXISTS `david_sterry` 

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `Engineers`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Engineers` (
  `EngineerId` int(11) NOT NULL AUTO_INCREMENT,
  `EngineerName` longtext,
  `HireDate` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000',
  PRIMARY KEY (`EngineerId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `MachineEnigneer`;

 SET character_set_client = utf8mb4 ;
CREATE TABLE `MachineEnigneer` (
  `MachineEngineerId` int(11) NOT NULL AUTO_INCREMENT,
  `MachineId` int(11) NOT NULL,
  `EngineerId` int(11) NOT NULL,
  PRIMARY KEY (`MachineEngineerId`),
  KEY `IX_MachineEnigneer_EngineerId` (`EngineerId`),
  KEY `IX_MachineEnigneer_MachineId` (`MachineId`),
  CONSTRAINT `FK_MachineEnigneer_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
  CONSTRAINT `FK_MachineEnigneer_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `Machines`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Machines` (
  `MachineId` int(11) NOT NULL AUTO_INCREMENT,
  `MachineName` longtext,
  `InstallDate` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000',
  PRIMARY KEY (`MachineId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```
You can now type the follow code into your terminal to launch the program.

<code>dotnet run</code>

The program should launch using your default web browser at URL: localhost:5000.

SQL Database Design
<center>
<img style="width: 50% height: 50%" src="./ReadMeAssets/FactoryDB.png">
</center>


## **Known Bugs**
There are no known bugs

## **Technology Used**
* C# 7.3
* .NET Core 2.2
* Entity
* Git
* MySQL
* CSS
* HMTL
* Bootstrap
* Razor
* dotnet script, REPL
  
## **Authors and Contributors**
Authored by: David Sterry

## **Contact**
If you have any issues during installation delete both the bin and obj folders and follow the set up instructions again. Please contact me at sterry.david@gmail.com in regards to this project

## **License**

This project is licensed under **MIT 2.0**

Copyright © 2020 David Sterry

