# CQRS

What it is
Separate writes (commands) and reads (queries) with different models and handlers.

Classic mechanics
- Write model enforces invariants; read model is optimized for queries.

Deep dive
- Consistency: reads may be eventually consistent; design UI expectations.
- Transactions: pair with Outbox to publish events atomically.
- Handlers: keep thin and explicit; test separately.

Modern .NET
- Use MediatR or similar for in-proc handlers.
- Split projects only when complexity warrants.

Pitfalls
- Overuse in simple apps; extra moving parts without benefit.

## Code
- C#: [Cqrs.cs](../../src/ArchitectPatterns.Console/Patterns/Cqrs.cs)
