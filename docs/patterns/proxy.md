# Proxy Pattern

What it is:
Provide a stand-in that controls access to a real object (lazy load, remote, security, cache).

When to use:
- Control access or add policy
- Virtual/remote resources

C# example:
public interface IImage { void Render(); }
public sealed class Image : IImage { public void Render(){ /* draw */ } }
public sealed class LazyImageProxy : IImage { private IImage _real; public void Render(){ _real ??= new Image(); _real.Render(); } }

Architect terms:
- Access mediation
- Lazy/eager trade-offs

## Code
- C#: [Proxy.cs](../../src/ArchitectPatterns.Console/Patterns/Proxy.cs)

