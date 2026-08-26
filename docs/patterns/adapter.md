# Adapter Pattern

What it is:
Convert one interface into another clients expect without changing the underlying system.

When to use:
- Integrate with legacy or third-party APIs
- Keep your domain model clean

C# example:
public interface IPayment { void Charge(decimal amount); }
public sealed class LegacyPay { public void MakePayment(int cents){} }
public sealed class LegacyAdapter : IPayment { private readonly LegacyPay _p=new(); public void Charge(decimal amount){ _p.MakePayment((int)(amount*100)); } }

Architect terms:
- Anti-corruption layer (DDD)
- Boundary mapping and impedance matching
