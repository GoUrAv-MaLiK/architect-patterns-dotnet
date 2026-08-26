using System; using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public sealed class Container { private readonly Dictionary<Type,Func<object>> _map=new(); public void AddSingleton<T>(Func<T> f) where T:class { var lazy=new Lazy<T>(f); _map[typeof(T)]=()=>lazy.Value!; } public T Get<T>() where T:class => (T)_map[typeof(T)](); }
