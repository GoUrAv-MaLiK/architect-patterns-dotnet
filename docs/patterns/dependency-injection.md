# Dependency Injection

What it is
Externalize creation and wiring of dependencies to improve testability and composition.

Deep dive
- Choose lifetimes consciously: Singleton, Scoped, Transient.
- Avoid service locator anti pattern; prefer constructor injection.
- Keep the composition root near the application entry point.

Modern .NET
- Use the built in container for most scenarios; add decorators and resilience policies via registrations.

## Code
- C#: [DependencyInjection.cs](../../src/ArchitectPatterns.Console/Patterns/DependencyInjection.cs)
