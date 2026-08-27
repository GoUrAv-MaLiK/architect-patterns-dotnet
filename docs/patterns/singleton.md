# Singleton Pattern

What it is
Ensure a class has exactly one instance and provide a global access point.

Why it exists
Some resources must be unique (config registry, scheduler, cache coordinator). Instantiating more than one can corrupt state or waste resources.

Classic implementation: Double‑Checked Locking (DCL)
```csharp
public sealed class Config
{
    private static Config? _instance;                 // the single instance (initially null)
    private static readonly object _gate = new();     // lock used only during first init
    private Config() {}

    public static Config Instance
    {
        get
        {
            // 1) First null check: fast path after initialization.
            //    If already created, we avoid taking the lock (performance).
            if (_instance is null)
            {
                lock (_gate) // lock only while creating the instance
                {
                    // 2) Second null check: correctness under race.
                    //    Two threads can pass the first check; this prevents double creation.
                    if (_instance is null)
                        _instance = new Config();
                }
            }
            return _instance;
        }
    }
}
```
How it works
- First null check: performance fast‑path; once initialized, no locking on reads.
- Lock: only contended during first initialization.
- Second null check: correctness; if two threads enter before lock, only one actually constructs.

Thread‑safety and the memory model
- On .NET, the pattern above is safe because publication happens while holding the lock; all writes made in the critical section are visible after the lock releases.
- Avoid doing heavy work under the lock; perform only construction there.

Lazy loading vs eager
- Lazy: defer work until first access; great for expensive init or optional features.
- Eager: initialize at startup for deterministic failures and simpler error handling.

Modern .NET: Lazy<T> (preferred)
```csharp
using System;

public sealed class Config
{
    private static readonly Lazy<Config> _lazy = new(
        () => new Config(),
        System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);

    public static Config Instance => _lazy.Value;  // thread‑safe, lazy, exception‑safe publication
    private Config() {}
}
```
Why Lazy<T>
- Handles double‑checked locking, thread‑safety, and publication correctly.
- Avoids writing (and maintaining) synchronization boilerplate.
- Consistent exception behavior: if the factory throws, subsequent Value calls re‑throw until resolved.

Alternatives and modern guidance
- Static initialization (eager & simple): `public static readonly Config Instance = new();`
- Prefer DI in application code: register a singleton service and inject it; testing/lifetimes become explicit.

Pitfalls
- Hidden global state makes tests flaky; prefer DI when feasible.
- Dispose: if the singleton holds unmanaged resources, plan for explicit shutdown.

## Code
- C#: [Singleton.cs](../../src/ArchitectPatterns.Console/Patterns/Singleton.cs)
