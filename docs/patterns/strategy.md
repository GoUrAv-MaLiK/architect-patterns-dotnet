# Strategy Pattern

What it is
Encapsulate interchangeable behaviors behind one interface to avoid if/else chains.

Why/when to use
- Many variants of a behavior (pricing, routing, ranking)
- Open/Closed extensibility
- Testability: swap a fake strategy in tests

Mechanics
- Define an interface (e.g., IPricing.Price()), implement concrete strategies.
- Client delegates to the interface; selection via DI or config.

Modern .NET
- Register strategies in DI and resolve by key (IEnumerable<IPricing> + selector).
- For tiny behaviors, use delegates Func<TIn,TOut>.
- Compose strategies for richer behavior.

Pitfalls
- Too many micro-classes without naming clarity.
- Scattered selection logic; centralize via factory or DI.

## Code
- C#: [Strategy.cs](../../src/ArchitectPatterns.Console/Patterns/Strategy.cs)
