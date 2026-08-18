# CollegeAPI

CollegeAPI is a RESTful ASP.NET Core Web API for managing student records. It supports creating, reading, updating, and deleting student data, and it exposes the API through Swagger for easy test and exploration.

## Features

- Retrieve all students
- Retrieve a single student by ID
- Create a new student
- Update an existing student
- Delete a student

## Tech stack

- ASP.NET Core Web API
- Entity Framework Core
- SQLite for local development
- Swagger / OpenAPI

## Run locally

```bash
dotnet restore
dotnet build
dotnet run
```

Then open:

- Swagger UI: http://localhost:5100/swagger
- Students API: http://localhost:5100/api/students

## Example payload

```json
{
  "firstName": "Alice",
  "lastName": "Johnson",
  "email": "alice@example.com",
  "phone": "1234567890",
  "dateOfBirth": "2000-01-15T00:00:00"
}
```

![CollegeAPI](https://github.com/user-attachments/assets/4fc87773-867e-48e8-ae54-0437a9af09fb)
