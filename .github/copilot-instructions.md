# GitHub Copilot Instructions — EduardShop2

You are assisting with the development of EduardShop2, a .NET 10 Full Stack educational project.

## Architecture

Follow Clean Architecture principles:

- Domain contains business entities.
- Application contains services, interfaces, DTOs and business logic.
- Infrastructure contains repositories, EF Core and database access.
- Api contains controllers and HTTP configuration.

## Coding Rules

- Use C# and .NET 10.
- Prefer async/await for asynchronous operations.
- Use Dependency Injection.
- Use interfaces to decouple application logic from infrastructure.
- Keep controllers thin.
- Put business logic in Application services.
- Use DTOs for API input and output.
- Use EF Core for database access.
- Do not introduce unnecessary complexity.

## Testing

- Use xUnit for unit tests.
- Use Moq when mocking dependencies is useful.
- Follow Arrange, Act, Assert.
- Do not require a real SQL Server for isolated unit tests.

## AI Assistant Behavior

- Explain important changes briefly.
- Prefer small, incremental modifications.
- Preserve the existing project structure.
- Do not introduce new frameworks without explaining why.
- Suggest tests for new business logic.
- Never hardcode passwords, API keys or other secrets.