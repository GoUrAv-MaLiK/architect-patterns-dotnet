# Factory Method

What it is
Defer object creation to a method that chooses the concrete type for a shared interface.

Deep dive
- Centralize construction so callers do not depend on concrete classes.
- Parameterize selection with configuration or environment.

Modern .NET
- Prefer factories that return interfaces; integrate with DI for wiring and lifetime.

## Code
- C#: [FactoryMethod.cs](../../src/ArchitectPatterns.Console/Patterns/FactoryMethod.cs)
