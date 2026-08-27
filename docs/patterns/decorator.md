# Decorator Pattern

What it is
Wrap an implementation to add behavior before/after calls without modifying the original class.

Classic mechanics
- Shared interface for component and decorator.
- Decorator holds an inner component and forwards calls with extra behavior.

Deep dive
- Great for cross cutting concerns: caching, logging, metrics, authorization.
- Stacking: order matters (e.g., cache inside retry vs outside).

Modern .NET
- Register decorators with DI; keep each decorator single responsibility.
- Make wrappers transparent in exceptions and telemetry.

Pitfalls
- Very deep chains reduce debuggability; add tracing and names.

## Code
- C#: [Decorator.cs](../../src/ArchitectPatterns.Console/Patterns/Decorator.cs)
