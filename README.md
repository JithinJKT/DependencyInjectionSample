# DependencyInjectionSample

# Service Lifetimes in .NET Dependency Injection

In .NET, particularly with the ASP.NET Core Dependency Injection framework, services can be registered with different lifetimes. The lifetime of a service determines how long the service will be instantiated and how it will be shared.

## Service Lifetimes

### Transient

- **Description**: Services are created each time they are requested.
- **Use Case**: Best suited for lightweight, stateless services.

### Scoped

- **Description**: Services are created once per request (or scope).
- **Use Case**: Suitable for services that should be created once per web request.

### Singleton

- **Description**: Services are created the first time they are requested and then reused for all subsequent requests.
- **Use Case**: Suitable for stateful services that should be shared across the application.

## Example Project

This project demonstrates the different service lifetimes in ASP.NET Core. By running the project and refreshing the page, you can observe how services behave based on their lifetimes.

### Running the Project

1. Clone the repository.
2. Open the project in your preferred IDE (e.g., Visual Studio).
3. Build and run the project.
4. Open a web browser and navigate to the provided URL (usually `https://localhost:5001`).
5. Refresh the page multiple times to see the differences in how the services are instantiated.

### Observing Changes

- **Transient Services**: A new instance is created every time the page is refreshed.
- **Scoped Services**: The same instance is used throughout a single request, but a new instance is created for each new request.
- **Singleton Services**: The same instance is used across all requests and page refreshes.

This demonstration helps to understand the practical implications of different service lifetimes in a real-world application.


