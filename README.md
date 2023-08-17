# Student-Management_Backend
Welcome to the Student Management Backend! This project provides the backend functionality for managing student records, allowing you to perform Create, Read, Update, and Delete (CRUD) operations.
## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)

## Introduction
This backend system is built using .NET and is designed to work in conjunction with a front-end application to manage student data efficiently. The system provides RESTful APIs to interact with the database and perform CRUD operations on student records.

## Features
- Create new student records
- Retrieve student information
- Update existing student records
- Delete student records

## Getting Started
### Prerequisites

Before you begin, make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Database Server (e.g., SQL Server)](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation
1. Clone this repository to your local machine.
   ```bash
   git clone https://github.com/your-username/Student-Management-Backend.git
2. Navigate to the project directory
   ```bash
   cd student-management-backend
3. Install the required dependencies.
   ```bash
   dotnet restore
4. Update the database connection string in the `appsettings.json` file.
5. Apply database migrations to create the required schema.
   ```bash
   dotnet ef database update
## Usage
1. Build and run the application.
    ```bash
   dotnet run
2. Access the API endpoints using your preferred tool (e.g., Postman, curl) at
   `http://localhost:5000/api`
   
