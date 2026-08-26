# Factory Method

What it is:
Defer object creation to providers that decide which concrete type to instantiate for a common interface.

When to use:
- Families of related products
- Hide constructor complexity
- Improve testability by injecting factories

C# example:
public interface ITransport{ void Ship(); }
sealed class Truck : ITransport { public void Ship(){ /* ship by road */ } }
sealed class ShipTransport : ITransport { public void Ship(){ /* ship by sea */ } }
static class TransportFactory { public static ITransport Create(string mode){ return mode=="sea" ? new ShipTransport() : new Truck(); } }

Java example:
interface Transport{ void ship(); }
final class Truck implements Transport { public void ship(){ /* road */ } }
final class Vessel implements Transport { public void ship(){ /* sea */ } }
final class TransportFactory { static Transport create(String mode){ return ("sea".equals(mode)) ? new Vessel() : new Truck(); } }

Architect terms:
- Creation encapsulation
- Substitution by contract
- Test seams via factories
