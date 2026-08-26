using System; using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public sealed record OutboxMessage(Guid Id, string Topic, string Payload, DateTime CreatedUtc, bool Sent);
public interface IOutbox { void Add(OutboxMessage msg); IReadOnlyList<OutboxMessage> Pending(); void MarkSent(Guid id); }
public sealed class InMemoryOutbox : IOutbox { private readonly List<OutboxMessage> _m=new(); public void Add(OutboxMessage msg)=>_m.Add(msg); public IReadOnlyList<OutboxMessage> Pending()=> _m.FindAll(m=>!m.Sent); public void MarkSent(Guid id){ var i=_m.FindIndex(m=>m.Id==id); if(i>=0) _m[i]=_m[i] with { Sent=true }; } }
