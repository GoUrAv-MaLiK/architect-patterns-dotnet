namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface IRepository { object? Get(int id); }
public sealed class DbRepo : IRepository { public object? Get(int id)=> new object(); }
public sealed class CachingRepo : IRepository { private readonly IRepository _inner; public CachingRepo(IRepository inner){ _inner=inner;} public object? Get(int id){ return _inner.Get(id); } }
