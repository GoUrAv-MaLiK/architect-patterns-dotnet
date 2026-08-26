# Decorator Pattern

What it is:
Attach additional behavior to objects dynamically without modifying the original class.

When to use:
- Cross-cutting concerns (logging, caching, auth)
- Compose behaviors at runtime

C# example:
public interface IRepository { object Get(int id); }
public sealed class DbRepo : IRepository { public object Get(int id)=> new object(); }
public sealed class CachingRepo : IRepository { private readonly IRepository _inner; public CachingRepo(IRepository inner){ _inner=inner;} public object Get(int id){ /* lookup cache then */ return _inner.Get(id);} }

Architect terms:
- Composition over inheritance
- Behavior layering

## Code
- C#: `src/ArchitectPatterns.Console/Patterns/
Decorator
.cs`
