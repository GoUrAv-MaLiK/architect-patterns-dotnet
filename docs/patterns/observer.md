# Observer Pattern

What it is:
Publish/subscribe updates from subject to observers without tight coupling.

When to use:
- Many listeners to state changes
- Event-driven UIs, domain events

C# example:
interface IObserver{ void OnPriceChanged(decimal price); }
sealed class Ticker{ private readonly System.Collections.Generic.List<IObserver> _obs=new(); private decimal _p; public void Subscribe(IObserver o)=>_obs.Add(o); public void Price(decimal p){ _p=p; foreach(var o in _obs) o.OnPriceChanged(p);} }

Java example:
interface Observer{ void onPriceChanged(double price); }
final class Ticker{ private final java.util.List<Observer> obs=new java.util.ArrayList<>(); private double p; void subscribe(Observer o){ obs.add(o);} void price(double price){ p=price; for(var o: obs) o.onPriceChanged(price);} }

Architect terms:
- Loose coupling via events
- Fan-out notifications
- Async boundaries (optionally)

Trade-offs:
- + Decouples producers/consumers
- - Ordering and backpressure need design

## Code
- C#: [Observer.cs](../../src/ArchitectPatterns.Console/Patterns/Observer.cs)

