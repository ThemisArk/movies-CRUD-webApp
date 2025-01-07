# Movie Database Web App

A simple web application built with ASP.NET Core MVC for managing a movie database. Users can perform basic CRUD operations (Create, Read, Update, Delete) on movie records through a basic user interface.

## Features

- **Add Movies**: Add new movie records to the database.
- **View Movies**: Display a list of movies with their details.
- **Update Movies**: Edit movie information.
- **Delete Movies**: Remove movies from the database.

## Tech Stack

- **Backend**: C#, ASP.NET Core MVC
- **Database**: SQL Server / SQLite (based on your implementation)
- **Frontend**: HTML, CSS, JavaScript (basic UI)

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/movie-database-web-app.git
    ```

2. Open the project in Visual Studio or Visual Studio Code.

3. Restore the NuGet packages:

    ```bash
    dotnet restore
    ```

4. Set up the database connection string in the `appsettings.json` file.

5. Apply the database migrations (if using Entity Framework Core):

    ```bash
    dotnet ef database update
    ```

6. Run the application:

    ```bash
    dotnet run
    ```

7. Open your browser and go to `http://localhost:5000`.

## Usage

- Use the basic UI to **add**, **view**, **update**, and **delete** movie records.
- The app provides a simple interface for managing the movie database through HTTP requests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

