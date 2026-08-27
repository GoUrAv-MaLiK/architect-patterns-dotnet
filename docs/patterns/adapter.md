# Adapter Pattern

What it is
Convert one interface into another that clients expect, without changing the underlying system.

Classic mechanics
- Target interface: what your code wants to call.
- Adaptee: legacy or third-party component.
- Adapter: translates calls, types, and error semantics.

Deep dive
- Mapping: convert DTOs and error codes to domain types and exceptions.
- Direction: uni-directional (preferred) vs bi-directional (harder to maintain).
- Boundaries: treat the adapter as an anti-corruption layer around vendors.

Modern .NET
- Keep adapters thin; move business logic into domain services.
- Convert exceptions to domain errors; normalize retries and timeouts above.

Pitfalls
- Leaking vendor types across the boundary.
- Putting business rules into the adapter.

## Code
- C#: [Adapter.cs](../../src/ArchitectPatterns.Console/Patterns/Adapter.cs)
