# EduardShop2

Educational Full Stack application built with .NET 10 and Angular.

## Technologies

- C# / .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Angular / TypeScript
- Docker / Docker Compose
- Git / GitHub
- GitHub Actions (CI)
- xUnit / Moq

## Architecture

The backend follows Clean Architecture principles.

- **Domain** — business entities such as Product.
- **Application** — services, interfaces and DTOs.
- **Infrastructure** — EF Core, repositories and SQL Server.
- **Api** — REST controllers and application configuration.
- **Tests** — automated tests.

## API Endpoints

- GET /api/products — retrieve products.
- POST /api/products — create a product.

## Running the Application

Run the backend and SQL Server using Docker Compose:

`docker compose up -d`

Alternatively, start EduardShop2.Api from Visual Studio.

## Development Roadmap

- Complete CRUD operations
- Angular frontend improvements
- Automated tests in CI
- Continuous Deployment (CD)
- GitHub Copilot integration
- AI API integration
- Azure deployment
- Kubernetes basics