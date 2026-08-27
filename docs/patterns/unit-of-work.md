# Unit of Work

What it is
Track changes and commit atomically as one transaction across multiple repositories or aggregates.

Deep dive
- One transaction boundary per use case; keep it short and predictable.
- Handle concurrency conflicts explicitly and retry when safe.

Modern .NET
- EF Core DbContext is the unit of work; wrap SaveChanges in a transaction when needed.

## Code
- C#: [UnitOfWork.cs](../../src/ArchitectPatterns.Console/Patterns/UnitOfWork.cs)
