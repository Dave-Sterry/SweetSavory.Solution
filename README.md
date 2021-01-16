# Pierre's Sweet and Savory Treats
<div align="center">
<img src="https://github.com/Dave-Sterry.png" width="200px" height="auto">
</div>

### A C# website by David Sterry 
Initialized on 01/15/21
Last updated on 01/15/21


## **Project Description**

This simple C# website is designed to help Pierre market his sweet and savory treats. Users will have to create an account, once they do they can log in and create, update and delete Treats and Flavors. If they click on a Treat or Flavor they will see all the Treats of Flavors assigned to it. This was a Friday independent project for epicodus, to showcase using Identity for Authentication, along with many to many relationship database managment. 

## **User Stories**
* The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.
* There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.
* A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.



## **Required for Use**
* C# and .Net Core installed on your local machine. Download .Net Core [Here](https://dotnet.microsoft.com/download) Follow the instructions to install on your machine
* Console/Terminal access.
* Code Editor like VSCode download [Here](https://code.visualstudio.com/) Follow the instructions to install on your machine
* MySQL Community Server download [Here](https://dev.mysql.com/downloads/mysql/) Follow the instructions to install on your machine
* MySQL Workbench [Here](https://www.mysql.com/products/workbench/) Follow the instructions to install on your machine
* An internet browser of your choice; I prefer Chrome


## **How to get this project** 

### Download from Github:
1. Use the browser navigate to my GitHub page [respository](https://github.com/Dave-Sterry/SweetSavory.Solution)
2. Click the Green **Code** button and select **Download Zip**

### Alternatively clone from Github via Gitbash:
1. In your terminal, navigate to the folder where you would like to clone the project too
2. Clone this repo to your chosen folder using "git clone https://github.com/Dave-Sterry/SweetSavory.Solution in terminal


## **Installation Instructions**
### **Setup Database Connection**

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the main `Factory` directory. 
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=david_sterry1;uid=YourId;pwd=YourPassword;"
  }
}
```
* Update the Server, Port, and User ID as needed with your own

Import Database using Entity Framework Core
* Navigate to SweetSavory.Solution/SweetSavory and type `dotnet ef database update` into the terminal. This will update the existing migrations 


## **Viewing the Project**
* Navitagate to SweetSavor.Solutions/SweetSavory in your terminal, and run the command `dotnet run` The program should launch using your default web browser. If it does not launch, navigate to the site at URL localhost:5000 in your favorite browser. 




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
* Identity 
  
## **Authors and Contributors**
Authored by: David Sterry

## **Contact**
If you have any issues during installation delete both the bin and obj folders and follow the set up instructions again. Please contact me at sterry.david@gmail.com in regards to this project

## **License**

This project is licensed under **MIT 2.0**

Copyright © 2020 David Sterry

