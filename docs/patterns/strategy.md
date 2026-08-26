# Strategy Pattern

What it is:
Select behavior at runtime by encapsulating algorithms behind a common interface.

When to use:
- Many interchangeable behaviors
- Open/closed principle for adding strategies
- Avoid long if/else on behavior

C# example:
```csharp
public interface IPricing { decimal Price(decimal basePrice); }
public sealed class RegularPricing : IPricing { public decimal Price(decimal p) => p; }
public sealed class DiscountPricing : IPricing { private readonly decimal _pct; public DiscountPricing(decimal pct)=>_pct=pct; public decimal Price(decimal p)=> p*(1-_pct); }
public sealed class Cart { private IPricing _pricing; public Cart(IPricing pricing)=>_pricing=pricing; public void SetPricing(IPricing p)=>_pricing=p; public decimal Checkout(decimal subtotal)=>_pricing.Price(subtotal);} 
```

Java example:
```java
interface Pricing { double price(double basePrice); }
final class RegularPricing implements Pricing { public double price(double p){ return p; } }
final class DiscountPricing implements Pricing { private final double pct; DiscountPricing(double pct){ this.pct=pct; } public double price(double p){ return p*(1-pct); } }
final class Cart { private Pricing pricing; Cart(Pricing p){ this.pricing=p; } void setPricing(Pricing p){ this.pricing=p; } double checkout(double subtotal){ return pricing.price(subtotal); } }
```

Architect terms:
- Pluggable policy
- Open/Closed
- Separation of concerns

Trade-offs:
- + Extensible behaviors
- - More types to manage
- - Strategy selection logic moves to client

## Code
- C#: `src/ArchitectPatterns.Console/Patterns/
Strategy
.cs`
