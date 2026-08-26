namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface ITransport{ string Ship(); }
public sealed class Truck : ITransport { public string Ship()=>"road"; }
public sealed class Vessel : ITransport { public string Ship()=>"sea"; }
public static class TransportFactory { public static ITransport Create(string mode)=> mode=="sea" ? new Vessel() : new Truck(); }
