# Singleton Pattern

What it is: Ensure a class has one instance and provide a global access point.

When to use:
- Single shared resource (config cache, registry)
- Expensive initialization that should be reused

C# example:
```csharp
using System;

public sealed class Config
{
    private static readonly Lazy<Config> _instance = new(() => new Config());
    public static Config Instance => _instance.Value;
    private Config() {}
}
```

Java example:
```java
final class Config {
    private static final Config I = new Config();
    private Config() {}
    static Config instance() { return I; }
}
```

Architect terms:
- Global state risk
- Prefer DI containers over hard singletons in apps

## Code
- C#: [Singleton.cs](../../src/ArchitectPatterns.Console/Patterns/Singleton.cs)
- Java: [Singleton.java](../../src/main/java/com/architect/patterns/examples/Singleton.java)
