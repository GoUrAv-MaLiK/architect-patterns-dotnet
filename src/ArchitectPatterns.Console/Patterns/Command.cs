using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface ICommand { void Execute(); }
public sealed class EmailCommand : ICommand { public void Execute(){ } }
public sealed class Invoker { private readonly Queue<ICommand> _q=new(); public void Enqueue(ICommand c)=>_q.Enqueue(c); public void Run(){ while(_q.Count>0) _q.Dequeue().Execute(); } }
