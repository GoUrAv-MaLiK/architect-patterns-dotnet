# Repository Pattern

What it is
Abstract access to aggregates as collection like interfaces hiding persistence details.

Deep dive
- Aggregate focus: operations should reflect invariants not CRUD for every table.
- Query leakage: keep ad hoc queries in read services instead.

Modern .NET
- EF Core DbContext already acts as repository + unit of work; adding a thin repo is optional.
- If used, keep interfaces small and domain oriented.

Pitfalls
- Generic repositories that expose IQueryable widely couple callers to the ORM.

## Code
- C#: [Repository.cs](../../src/ArchitectPatterns.Console/Patterns/Repository.cs)
