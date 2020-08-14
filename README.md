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


## Specifications

  | Program Behavior | Example Behavior | Example Output | Met? (Y/N) |
  | ----------- | ----------- | ----------- | ----------- |
  | Program will display a splash page allowing a user to view all Flavors, view all Treats, log into their account, or register an account. | N/A | "Pierre's Sweet & Savory Treats / Internal Flavor & Treat Database / View All Flavors / View All Treats / Log Into Your Account / Register an Account" | Y |
  | When the "View All Flavors" link is clicked and no Flavors have been entered into the database, the program will display a view with a message to that effect. |  |  |  |
  | When the "View All Treats" link is clicked and no Treats have been entered into the database, the program will display a view with a message to that effect. |  |  |  |
  | When the "Login" link is clicked, the program will display a view with a form for the user to enter their Email and Password to log in. |  |  |  |
  | When the "Register an Account" link is clicked, the program will display a view with a form for the user to enter their Email and choose a password in order to create an account. |  |  |  |
  | When the "View All Flavors" link is clicked and at least one Flavor has been entered into the database, the program will display a view that lists all inputted Flavors. |  |  |  |
  | When the "View All Treats" link is clicked and at least one Treat has been entered into the database, the program will display a view that lists all inputted Treats. |  |  |  |
  | When the name of a Flavor in the Flavors index view is clicked and no Treats have been associated with that Flavor, the program will display a Details view with a message to that effect. |  |  |  |
  | When the name of a Treat in the Treats index view is clicked and no Flavors have been associated with that Treat, the program will display a Detail view with a message to that effect. |  |  |  |
  | Program will display an "Add Treat" link in the Flavors/Details view that will allow a user to associate a Treat with the Flavor that is displayed. |  |  |  |
  | Program will display an "Add Flavor" link in the Treats/Details view that will allow a user to associate a Flavor with the Treat that is displayed. |  |  |  |
  | When the name of a Flavor in the Flavors index view is clicked and at least one Treat has been associated with that Flavor, the program will display a Flavors/Details view listing all Treats that have been so associated. |  |  |  |
  | When the name of a Treat in the Treats index view is clicked and at least one Flavor has been associated with that Treat, the program will display a Treats/Details view listing all Flavors that have been so associated. |  |  |  |
  | Program will display an "Edit Flavor" link in the Flavors/Details view that, when clicked, will allow the user to change the name of the Flavor. |  |  |  |
  | Program will display an "Edit Treat" link in the Treats/Details view that, when clicked, will allow the user to change the name of the Treat. |  |  |  |
  | Program will display a "Delete" button for each Flavor in the Flavors/Index view that, when clicked, will remove the Flavor from the database. |  |  |  |
  | Program will display a "Delete" button for each Treat in the Treats/Index view that, when clicked, will remove the Treat from the database. |  |  |  |
  | Program will only allow the user to create, edit, add, remove, or delete Flavors and Treats if the user is logged in. |  |  |  |


## Known Bugs

| Location : Message |  Situation  | Resolved (Y/N) |  Bug Resolution Strategy |
| ----------- | ----------- | ----------- | ----------- |



## Support & Contact Details

  * You are welcome to contact the [author](https://github.com/taylorsomers/) via GitHub with any concerns, feedback, possible contributions, questions, or suggestions.


### Contributors

  * [Taylor Somers](https://github.com/taylorsomers/)


### License

  * This program is free to use under the GNU General Public License GPLv3. © 2020 Taylor Somers. All rights reserved.