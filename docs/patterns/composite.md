# Composite Pattern

What it is
Treat part whole hierarchies uniformly by using the same interface for leaves and groups.

Classic mechanics
- Composite keeps a collection of the same interface.
- Operations recurse down the tree and combine results.

Deep dive
- Aggregation rules: define associativity and identity (e.g., sum starts at 0).
- Performance: cache expensive results and invalidate on change.

Modern .NET
- Prefer immutable structures when feasible; otherwise expose explicit mutation methods.

## Code
- C#: [Composite.cs](../../src/ArchitectPatterns.Console/Patterns/Composite.cs)
