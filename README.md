# Movie Database Web App

A simple web application built with ASP.NET Core MVC for managing a movie database. Users can perform basic CRUD operations (Create, Read, Update, Delete) on movie records through a basic user interface.

## Features

- **Add Movies**: Add new movie records to the database.
- **View Movies**: Display a list of movies with their details.
- **Update Movies**: Edit movie information.
- **Delete Movies**: Remove movies from the database (Hard delete).

## Tech Stack

- **Backend**: C#, ASP.NET Core MVC, EFCore
- **Database**: MSSQL
- **Frontend**: HTML, Razor

## Getting Started

1. **Clone the repository**:
   ```bash
   git clone https://github.com/ThemisArk/movies-CRUD-webApp.git
2. **Restore NuGet packages**:
   Open the solution in Visual Studio or use the command line to restore the required packages
   ```bash
   cd movies-CRUD-webApp
   dotnet restore
3. **Set up the database**:
   You can use Entity Framework migrations to set up the database. Run the following commands to apply the migrations and update the database schema:
   ```bash
   dotnet ef database update

6. **Run the application**:  
   Build and run the project using Ctrl + F5.

## Usage

- Create a new movie by filling out the movie form and submitting it.
- Read a list of all movies in the database, with options to view individual movie details.
- Update an existing movie by clicking the "Edit" button next to a movie entry.
- Delete a movie by clicking the "Delete" button.
- Search for movies in the database by title or by its genre.

## Testing
For testing, you can either manually interact with the application through the web interface or use tools like Postman to test the API endpoints.

## License
This project is open-source and available under the MIT License.

