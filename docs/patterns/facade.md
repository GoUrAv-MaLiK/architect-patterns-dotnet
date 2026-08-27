# Facade

What it is
Provide a single, simple API that orchestrates multiple subsystems.

Classic mechanics
- A public Facade class exposes a minimal surface.
- Internally it calls encoder/uploader/repository/etc. in order, handling errors.

Deep dive
- Orchestration vs choreography: Facade owns ordering and error handling, not the callees.
- Idempotency: define what happens on retry; make repeated calls safe where possible.
- Failure policy: which errors bubble vs translate to domain errors.
- Observability: emit one trace/span that encloses all internal calls.

Modern .NET
- Keep the facade thin; business rules live in domain services it composes.
- Surface timeouts and cancellation tokens; use resilience policies (Polly) when calling IO.

## Code
- C#: [Facade.cs](../../src/ArchitectPatterns.Console/Patterns/Facade.cs)
