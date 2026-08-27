# Proxy Pattern

What it is
Provide a stand in that controls access to a real object (lazy load, remote call, or protection).

Classic mechanics
- Virtual proxy: instantiate the heavy object on first use.
- Remote proxy: hide RPC transport and marshaling.
- Protection proxy: enforce policy before delegation.

Deep dive
- Expose timeouts, retries, and cancellation explicitly for remote proxies.
- Avoid surprising caching; document lifetime and consistency.

Modern .NET
- Use HttpClientFactory and resilience policies for remote proxies.
- Consider dynamic proxies for AOP like concerns in infrastructure code.

## Code
- C#: [Proxy.cs](../../src/ArchitectPatterns.Console/Patterns/Proxy.cs)
