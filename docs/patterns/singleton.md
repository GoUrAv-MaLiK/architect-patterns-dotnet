# Singleton Pattern

What it is:
Ensure a class has one instance and provide a global access point.

When to use:
- Single shared resource (config cache, registry)
- Expensive init that should be reused

C# example:
public sealed class Config { private static readonly Lazy<Config> _i=new(()=>new Config()); public static Config Instance=>_i.Value; private Config(){} }

Java example:
final class Config { private static final Config I = new Config(); private Config(){} static Config instance(){ return I; } }

Architect terms:
- Global state risk
- Prefer DI containers over hard singletons in apps

## Code
- C#: `src/ArchitectPatterns.Console/Patterns/
Singleton
.cs`
