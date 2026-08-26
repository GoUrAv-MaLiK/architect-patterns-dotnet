namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface IPayment { void Charge(decimal amount); }
public sealed class LegacyPay { public void MakePayment(int cents){} }
public sealed class LegacyAdapter : IPayment { private readonly LegacyPay _p=new(); public void Charge(decimal amount){ _p.MakePayment((int)(amount*100)); } }
