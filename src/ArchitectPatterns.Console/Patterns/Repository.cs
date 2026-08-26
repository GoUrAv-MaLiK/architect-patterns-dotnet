using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface IEntity{ int Id { get; } }
public interface IRepository<T> where T: IEntity { T? Get(int id); void Add(T entity); }
public sealed class InMemoryRepository<T> : IRepository<T> where T: class, IEntity { private readonly Dictionary<int,T> _data=new(); public T? Get(int id)=> _data.TryGetValue(id, out var v) ? v : null; public void Add(T e)=> _data[e.Id]=e; }
