using System; using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface IUnitOfWork : IDisposable { void Commit(); }
public sealed class InMemoryUnitOfWork : IUnitOfWork { private readonly List<Action> _ops=new(); public void Track(Action op)=>_ops.Add(op); public void Commit(){ foreach(var op in _ops) op(); _ops.Clear(); } public void Dispose(){} }
