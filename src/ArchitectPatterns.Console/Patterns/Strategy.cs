namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface IPricing { decimal Price(decimal basePrice); }
public sealed class RegularPricing : IPricing { public decimal Price(decimal p) => p; }
public sealed class DiscountPricing : IPricing { private readonly decimal _pct; public DiscountPricing(decimal pct){ _pct=pct; } public decimal Price(decimal p) => p*(1-_pct); }
