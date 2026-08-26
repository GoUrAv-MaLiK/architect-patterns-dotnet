# Composite Pattern

What it is:
Treat part-whole hierarchies uniformly; clients operate on single objects and compositions with the same interface.

When to use:
- Tree structures (menus, org charts, UI components)

C# example:
public interface INode{ int Size(); }
public sealed class Leaf : INode { public int Size()=>1; }
public sealed class Group : INode { private readonly System.Collections.Generic.List<INode> _children=new(); public void Add(INode n)=>_children.Add(n); public int Size(){ int s=0; foreach(var c in _children) s+=c.Size(); return s; } }

Architect terms:
- Uniform interfaces
- Recursive composition

## Code
- C#: `src/ArchitectPatterns.Console/Patterns/
Composite
.cs`
