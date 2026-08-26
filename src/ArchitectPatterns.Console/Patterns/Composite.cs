using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface INode{ int Size(); }
public sealed class Leaf : INode { public int Size()=>1; }
public sealed class Group : INode { private readonly List<INode> _children=new(); public void Add(INode n)=>_children.Add(n); public int Size(){ int s=0; foreach(var c in _children) s+=c.Size(); return s; } }
