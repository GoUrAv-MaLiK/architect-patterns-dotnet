namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface IState { IState Next(); string Name { get; } }
public sealed class Draft : IState { public IState Next()=> new Published(); public string Name=>"Draft"; }
public sealed class Published : IState { public IState Next()=> new Archived(); public string Name=>"Published"; }
public sealed class Archived : IState { public IState Next()=> this; public string Name=>"Archived"; }
