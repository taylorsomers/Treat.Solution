# Dr Sneuss's Factory

  ### By [Taylor Somers](https://github.com/taylorsomers/)

## Description

  This program is a demonstration of user authentication with Identity in the context of a bakery application that uses many-to-many MySQL database relationships to allow users to access create, update, and delete functionality for Treats and Flavors only if they are signed in. Each Flavor may be associated with many Treats, and each Treat may be may be associated with many Flavors. Users will be able to view content whether or not they are signed in, but will only be able to create, update, or delete objects in the application *if* they are signed in. The essential features of C# and .NET development using databases are present and easily usable, and the use of authentication with Identity in the context of a many-to-many object-oriented application is demonstrated. The application was build using C#/.NET, CSHTML, and MySQL with Entity Framework according to an MVC standard.


## Languages & Technologies Used:

  ### Programming Languages, Libraries, & Frameworks
  * CSHTML
  * CSS
  * C#
  * Entity Framework
  * MVC
  * MySQL
  * .NET Core
  * Razor

  ### Operating Systems & Programs
  * Brave
  * Microsoft PowerShell
  * Microsoft Windows 10
  * Visual Studio Code

## Installation

  1.  Download a web browser, such as Apple Safari, Brave, Google Chrome, Microsoft Edge, Mozilla Firefox, or Yandex.
  2.  Navigate to https://github.com/taylorsomers/Treat.Solution.
  3.  Click the green "Clone or download" button at the right of the screen.
  4.  Select "Download ZIP."
  5.  Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.
  6.  In your browser, navigate to https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer for Mac or https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer for Windows and click the link "click here to download manually" if the download for .NET Core 2.2 SDK does not start automatically.
  7.  Double-click the downloaded .NET Core 2.2 SDK file and run the installer.
  8.  Open your computer's terminal and navigate to the "Factory" subdirectory within the "Factory.Solution" directory.
  9.  Import the file "taylor_somers.sql" using your preferred SQL management tool.
  10. Enter the command "dotnet build" in the terminal.
  11. Enter the command "dotnet run" in the terminal. The program should begin to run in your browser.

  ### Database Setup Instructions

  CREATE DATABASE  IF NOT EXISTS `taylor_somers`;
  USE `taylor_somers`;
  -- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
  --
  -- Host: 127.0.0.1    Database: taylor_somers
  -- ------------------------------------------------------
  -- Server version	8.0.21

  --
  -- Table structure for table `__efmigrationshistory`
  --

  DROP TABLE IF EXISTS `__efmigrationshistory`;
  CREATE TABLE `__efmigrationshistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  --
  -- Table structure for table `aspnetroleclaims`
  --

  DROP TABLE IF EXISTS `aspnetroleclaims`;
  CREATE TABLE `aspnetroleclaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `RoleId` varchar(255) NOT NULL,
    `ClaimType` longtext,
    `ClaimValue` longtext,
    PRIMARY KEY (`Id`),
    KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
    CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  --
  -- Table structure for table `aspnetroles`
  --

  DROP TABLE IF EXISTS `aspnetroles`;
  CREATE TABLE `aspnetroles` (
    `Id` varchar(255) NOT NULL,
    `Name` varchar(256) DEFAULT NULL,
    `NormalizedName` varchar(256) DEFAULT NULL,
    `ConcurrencyStamp` longtext,
    PRIMARY KEY (`Id`),
    UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  --
  -- Table structure for table `aspnetuserclaims`
  --

  DROP TABLE IF EXISTS `aspnetuserclaims`;
  CREATE TABLE `aspnetuserclaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` varchar(255) NOT NULL,
    `ClaimType` longtext,
    `ClaimValue` longtext,
    PRIMARY KEY (`Id`),
    KEY `IX_AspNetUserClaims_UserId` (`UserId`),
    CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  --
  -- Table structure for table `aspnetuserlogins`
  --

  DROP TABLE IF EXISTS `aspnetuserlogins`;
  CREATE TABLE `aspnetuserlogins` (
    `LoginProvider` varchar(255) NOT NULL,
    `ProviderKey` varchar(255) NOT NULL,
    `ProviderDisplayName` longtext,
    `UserId` varchar(255) NOT NULL,
    PRIMARY KEY (`LoginProvider`,`ProviderKey`),
    KEY `IX_AspNetUserLogins_UserId` (`UserId`),
    CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  --
  -- Table structure for table `aspnetuserroles`
  --

  DROP TABLE IF EXISTS `aspnetuserroles`;
  CREATE TABLE `aspnetuserroles` (
    `UserId` varchar(255) NOT NULL,
    `RoleId` varchar(255) NOT NULL,
    PRIMARY KEY (`UserId`,`RoleId`),
    KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
    CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  --
  -- Table structure for table `aspnetusers`
  --

  DROP TABLE IF EXISTS `aspnetusers`;
  CREATE TABLE `aspnetusers` (
    `Id` varchar(255) NOT NULL,
    `UserName` varchar(256) DEFAULT NULL,
    `NormalizedUserName` varchar(256) DEFAULT NULL,
    `Email` varchar(256) DEFAULT NULL,
    `NormalizedEmail` varchar(256) DEFAULT NULL,
    `EmailConfirmed` bit(1) NOT NULL,
    `PasswordHash` longtext,
    `SecurityStamp` longtext,
    `ConcurrencyStamp` longtext,
    `PhoneNumber` longtext,
    `PhoneNumberConfirmed` bit(1) NOT NULL,
    `TwoFactorEnabled` bit(1) NOT NULL,
    `LockoutEnd` datetime(6) DEFAULT NULL,
    `LockoutEnabled` bit(1) NOT NULL,
    `AccessFailedCount` int NOT NULL,
    PRIMARY KEY (`Id`),
    UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
    KEY `EmailIndex` (`NormalizedEmail`)
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  --
  -- Table structure for table `aspnetusertokens`
  --

  DROP TABLE IF EXISTS `aspnetusertokens`;
  CREATE TABLE `aspnetusertokens` (
    `UserId` varchar(255) NOT NULL,
    `LoginProvider` varchar(255) NOT NULL,
    `Name` varchar(255) NOT NULL,
    `Value` longtext,
    PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
    CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  --
  -- Table structure for table `flavors`
  --

  DROP TABLE IF EXISTS `flavors`;
  CREATE TABLE `flavors` (
    `FlavorId` int NOT NULL AUTO_INCREMENT,
    `FlavorName` longtext,
    PRIMARY KEY (`FlavorId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  --
  -- Table structure for table `flavortreat`
  --

  DROP TABLE IF EXISTS `flavortreat`;
  CREATE TABLE `flavortreat` (
    `FlavorTreatId` int NOT NULL AUTO_INCREMENT,
    `FlavorId` int NOT NULL,
    `TreatId` int NOT NULL,
    PRIMARY KEY (`FlavorTreatId`),
    KEY `IX_FlavorTreat_FlavorId` (`FlavorId`),
    KEY `IX_FlavorTreat_TreatId` (`TreatId`),
    CONSTRAINT `FK_FlavorTreat_Flavors_FlavorId` FOREIGN KEY (`FlavorId`) REFERENCES `flavors` (`FlavorId`) ON DELETE CASCADE,
    CONSTRAINT `FK_FlavorTreat_Treats_TreatId` FOREIGN KEY (`TreatId`) REFERENCES `treats` (`TreatId`) ON DELETE CASCADE
  ) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  --
  -- Table structure for table `treats`
  --

  DROP TABLE IF EXISTS `treats`;
  CREATE TABLE `treats` (
    `TreatId` int NOT NULL AUTO_INCREMENT,
    `TreatName` longtext,
    `UserId` varchar(255) DEFAULT NULL,
    PRIMARY KEY (`TreatId`),
    KEY `IX_Treats_UserId` (`UserId`),
    CONSTRAINT `FK_Treats_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE RESTRICT
  ) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

## Specifications

  | Program Behavior | Example Behavior | Example Output | Met? (Y/N) |
  | ----------- | ----------- | ----------- | ----------- |
  | Program will display a splash page allowing a user to view all Flavors, view all Treats, log into their account, or register an account. | N/A | "Pierre's Sweet & Savory Treats / Internal Flavor & Treat Database / View All Flavors / View All Treats / Log Into Your Account / Register an Account" | Y |
  | When the "View All Flavors" link is clicked and no Flavors have been entered into the database, the program will display a view with a message to that effect. |  |  | Y |
  | When the "View All Treats" link is clicked and no Treats have been entered into the database, the program will display a view with a message to that effect. |  |  | Y |
  | When the "Login" link is clicked, the program will display a view with a form for the user to enter their Email and Password to log in. |  |  | Y |
  | When the "Register an Account" link is clicked, the program will display a view with a form for the user to enter their Email and choose a password in order to create an account. |  |  | Y |
  | When the "View All Flavors" link is clicked and at least one Flavor has been entered into the database, the program will display a view that lists all inputted Flavors. |  |  | Y |
  | When the "View All Treats" link is clicked and at least one Treat has been entered into the database, the program will display a view that lists all inputted Treats. |  |  | Y |
  | When the name of a Flavor in the Flavors index view is clicked and no Treats have been associated with that Flavor, the program will display a Details view with a message to that effect. |  |  | Y |
  | When the name of a Treat in the Treats index view is clicked and no Flavors have been associated with that Treat, the program will display a Detail view with a message to that effect. |  |  | Y |
  | Program will display an "Add Treat" link in the Flavors/Details view that will allow a user to associate a Treat with the Flavor that is displayed. |  |  | Y |
  | Program will display an "Add Flavor" link in the Treats/Details view that will allow a user to associate a Flavor with the Treat that is displayed. |  |  | Y |
  | When the name of a Flavor in the Flavors index view is clicked and at least one Treat has been associated with that Flavor, the program will display a Flavors/Details view listing all Treats that have been so associated. |  |  | Y |
  | When the name of a Treat in the Treats index view is clicked and at least one Flavor has been associated with that Treat, the program will display a Treats/Details view listing all Flavors that have been so associated. |  |  | Y |
  | Program will display an "Edit Flavor" link in the Flavors/Details view that, when clicked, will allow the user to change the name of the Flavor. |  |  | Y |
  | Program will display an "Edit Treat" link in the Treats/Details view that, when clicked, will allow the user to change the name of the Treat. |  |  | Y |
  | Program will display a "Delete" button for each Flavor in the Flavors/Index view that, when clicked, will remove the Flavor from the database. |  |  | Y |
  | Program will display a "Delete" button for each Treat in the Treats/Index view that, when clicked, will remove the Treat from the database. |  |  | Y |
  | Program will only allow the user to create, edit, add, remove, or delete Flavors and Treats if the user is logged in. |  |  | Y |


## Known Bugs

| Location : Message |  Situation  | Resolved (Y/N) |  Bug Resolution Strategy |
| ----------- | ----------- | ----------- | ----------- |
| Treats/Controllers/FlavorsController.cs : "error CS1520: Method must have a return type" | Build error with message that database constructor must have a return type, though this is not required in other Controller files" | Y | Rename misnamed controller from "TreatsController to FlavorsController in Treats/Controllers/FlavorsController.cs file. |


## Support & Contact Details

  * You are welcome to contact the [author](https://github.com/taylorsomers/) via GitHub with any concerns, feedback, possible contributions, questions, or suggestions.


### Contributors

  * [Taylor Somers](https://github.com/taylorsomers/)


### License

  * This program is free to use under the GNU General Public License GPLv3. © 2020 Taylor Somers. All rights reserved.