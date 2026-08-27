# Command Pattern

What it is
Encapsulate a request so you can queue, log, retry, or undo.

Classic mechanics
- ICommand.Execute() holds intent and data.
- Invoker schedules; receiver performs the action.

Deep dive
- Reliability: idempotency keys for safe retries.
- Ordering: define guarantees if commands interact.
- Auditing: commands provide a durable intent log.

Modern .NET
- In-proc: simple queue with handlers.
- Cross-proc: enqueue to a broker and use backoff with resilience policies.

Pitfalls
- Hidden coupling between commands; document preconditions.

## Code
- C#: [Command.cs](../../src/ArchitectPatterns.Console/Patterns/Command.cs)
