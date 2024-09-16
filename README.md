CRUD Operations with DataGridView in C# and SQL Server

This project demonstrates performing CRUD (Create, Read, Update, Delete) operations using DataGridView in a C# Windows Forms application connected to a SQL Server database. The operations target an Employees table that stores employee information.


Appendix

Prerequisites:

Visual Studio: Ensure you have Visual Studio 2019 or later installed with C# development support.
SQL Server: SQL Server should be installed and set up with a database named project.
Features

Insert: Add a new employee to the database by entering their Name, ID, and Salary.

Update: Modify the details (Name and Salary) of an existing employee using their ID.

Delete: Remove an employee from the database by providing their ID.

Search: Retrieve and display details of an employee using their ID.

Screenshots:
<a href="https://postimg.cc/JHBjkpPM" target="_blank"><img src="https://i.postimg.cc/90LbsS9R/Screenshot-2024-09-16-233737.png" alt="Screenshot-2024-09-16-233737"/></a><br/><br/>
<a href="https://postimg.cc/rzd13pc3" target="_blank"><img src="https://i.postimg.cc/L4DxqqW9/Screenshot-2024-09-16-233756.png" alt="Screenshot-2024-09-16-233756"/></a><br/><br/>
<a href="https://postimg.cc/mh0YsGgD" target="_blank"><img src="https://i.postimg.cc/QxM0c8Lp/Screenshot-2024-09-16-233811.png" alt="Screenshot-2024-09-16-233811"/></a><br/><br/>





Tech Stack

C#: Used to build the Windows Forms application.

SQL Server: Used as the backend database to store employee information.

ADO.NET: Utilized for database interaction (executing SQL commands and retrieving data).


Usage/Examples
1. Insert Employee:
Fill in the fields for Name, ID, and Salary.
Click the Insert button to save the employee record to the database.

2. Update Employee:
Enter the ID of the employee you want to update.
Modify the Name or Salary fields.
Click the Update button to apply the changes to the database.

3. Delete Employee:
Enter the ID of the employee you want to delete.
Click the Delete button to remove the employee from the database.

4. Search Employee:
Enter the ID of the employee you want to search.
Click the Search button to retrieve the employee details and display them in the DataGridView.
