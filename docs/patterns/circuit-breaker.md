# Circuit Breaker

What it is
Fail fast after repeated errors, then probe for recovery.

States
- Closed -> normal
- Open -> fail immediately
- Half-Open -> limited probes

Deep dive
- Trip conditions: failure counts or error ratios over a window.
- Recovery: allow a probe and reset on success.
- Telemetry: export metrics for alerts.

Modern .NET
- Use Polly for breaker, retry, timeout, fallback; compose policies.

Pitfalls
- Hiding real outages with too-aggressive fallbacks.

## Code
- C#: [CircuitBreaker.cs](../../src/ArchitectPatterns.Console/Patterns/CircuitBreaker.cs)
