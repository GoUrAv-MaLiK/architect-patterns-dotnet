using System; using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface ICommand{} public interface IQuery<R>{} 
public interface IHandle<in TCommand> where TCommand:ICommand { void Handle(TCommand cmd);}
public interface IHandleQ<in TQuery,R> where TQuery:IQuery<R> { R Handle(TQuery q); }
public sealed record CreateUser(string Email):ICommand;
public sealed record GetUser(string Email):IQuery<User?>;
public sealed record User(string Email);
public sealed class InMemoryUsers : IHandle<CreateUser>, IHandleQ<GetUser,User?> { private readonly Dictionary<string,User> _db = new(); public void Handle(CreateUser c){ _db[c.Email]=new User(c.Email); } public User? Handle(GetUser q)=> _db.TryGetValue(q.Email, out var u) ? u : null; }
