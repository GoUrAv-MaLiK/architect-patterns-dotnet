# Event Sourcing

What it is
Persist state as a sequence of domain events; rebuild aggregates by replaying them.

Classic mechanics
- Append-only event log (immutable).
- Aggregate.Apply(event) mutates state; commands decide which events to append.
- Projections materialize read models from the event stream.

Deep dive
- Versioning: evolve events with upcasters or multiple handlers.
- Idempotency: ensure replays do not double-apply side effects.
- Snapshots: store periodic aggregate snapshots to speed up load.
- Ordering: per-aggregate sequence numbers; cross-aggregate ordering is not guaranteed.

Modern .NET
- Keep aggregates small and pure; side effects happen after persisting events.
- Use Outbox to publish integration events atomically with state changes.

## Code
- C#: [EventSourcing.cs](../../src/ArchitectPatterns.Console/Patterns/EventSourcing.cs)
