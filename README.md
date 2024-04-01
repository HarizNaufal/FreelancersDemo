Overview

This project implements a RESTful API for managing user data using the HTTP verbs GET, POST, PUT, and DELETE. The API allows users to register new users, retrieve user information, update user details, and delete user records. It connects to the Microsoft SQL Server as the relational database management system (RDBMS) to demonstrate data storage.

Features

HTTP Verbs: 
- GET: Retrieve user information.
- POST: Register a new user.
- PUT: Update user details.
- DELETE: Delete a user record.
  
User Attributes: username, email, phone, skillset, hobby

Database Connectivity: Microsoft SQL Server

Usage

To utilize the RESTful API for user management, follow these steps:
1. Installation:
Clone the repository to your local machine.
2. Configuration:
Update the connection string in the application settings to connect to your RDBMS database.
3. Build and Run:
Build and run the application to start the API server.

API Endpoints: Use the following endpoints to interact with the API:

- GET /api/user/{id}: Retrieve user information by ID.
- POST /api/user/register: Register a new user.
- PUT /api/user/{id}: Update user details by ID.
- DELETE /api/user/{id}: Delete a user record by ID.

Technologies Used

ASP.NET Core,
C#,
SQL Server

