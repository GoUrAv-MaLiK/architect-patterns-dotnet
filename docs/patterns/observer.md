# Observer Pattern

What it is
Publish or subscribe to state changes without tight coupling between producer and listeners.

Classic mechanics
- Subject holds a list of observers and notifies them on change.
- Observers implement a callback interface.

Deep dive
- Push vs pull: push data in the notification or let observers fetch the latest state.
- Ordering: define if notifications are FIFO and whether reentrancy is allowed.
- Backpressure: for hot sources, consider buffering or dropping strategies.

Modern .NET
- UI/events: C# events or IObservable/IObserver (Reactive Extensions).
- Domain events: publish inside a transaction and deliver via Outbox for cross service delivery.
- Prefer immutable event payloads.

Pitfalls
- Memory leaks from forgotten subscriptions; dispose carefully or use weak subscriptions.
- Hidden synchronous work inside handlers can stall producers.

## Code
- C#: [Observer.cs](../../src/ArchitectPatterns.Console/Patterns/Observer.cs)
