using System; using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface ISagaStep{ bool Execute(); void Compensate(); }
public sealed class SagaRunner { private readonly List<ISagaStep> _steps=new(); public SagaRunner Add(ISagaStep s){ _steps.Add(s); return this; } public bool Run(){ var completed=new Stack<ISagaStep>(); foreach(var s in _steps){ if(s.Execute()){ completed.Push(s);} else { while(completed.Count>0) completed.Pop().Compensate(); return false; } } return true; } }
