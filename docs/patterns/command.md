# Command Pattern

What it is:
Encapsulate a request as an object to queue, log, retry, or compose operations.

When to use:
- Undo/redo, task queues, retries
- Decouple invokers from receivers

C# example:
public interface ICommand { void Execute(); }
public sealed class EmailCommand : ICommand { public void Execute(){ /* send email */ } }
public sealed class Invoker { private readonly System.Collections.Generic.Queue<ICommand> _q=new(); public void Enqueue(ICommand c)=>_q.Enqueue(c); public void Run(){ while(_q.Count>0) _q.Dequeue().Execute(); } }

Java example:
interface Command { void execute(); }
final class EmailCommand implements Command { public void execute(){ /* send */ } }
final class Invoker { private final java.util.Queue<Command> q=new java.util.ArrayDeque<>(); void enqueue(Command c){ q.add(c);} void run(){ while(!q.isEmpty()) q.remove().execute(); } }

Architect terms:
- Task abstraction
- Reliability patterns (retries, DLQs)

## Code
- C#: [Command.cs](../../src/ArchitectPatterns.Console/Patterns/Command.cs)

