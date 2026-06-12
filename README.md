# Customer Management Web

## Overview

This is an ASP.NET Core MVC application that manages customers through the Customer Management API.

## Features

- Create Customer
- View Customers
- Update Customer
- Delete Customer
- Search Customers
- Client-side Validation

## Technologies

- ASP.NET Core MVC
- Razor Views
- Bootstrap 5
- Knockout.js
- jQuery AJAX
- SQL Server

## Architecture

The application uses a proxy pattern:

Browser → MVC Application → Customer API → Database

This prevents CORS issues because the browser only communicates with the MVC application.

## Running the Application

1. Start the Customer Management API
2. Update the API Base URL in `appsettings.json`
3. Run the MVC application
4. Open the application in your browser
