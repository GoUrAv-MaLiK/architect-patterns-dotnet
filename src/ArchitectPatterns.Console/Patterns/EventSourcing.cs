using System; using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface IEvent{}
public sealed record UserRegistered(string Email):IEvent;
public sealed record EmailChanged(string Email):IEvent;
public sealed class UserAggregate { public string Email{ get; private set;} = string.Empty; public List<IEvent> Changes { get; } = new(); public static UserAggregate From(IEnumerable<IEvent> history){ var u = new UserAggregate(); foreach(var e in history) u.Apply(e); return u; } public void Register(string email){ Apply(new UserRegistered(email), true); } public void ChangeEmail(string email){ Apply(new EmailChanged(email), true); } private void Apply(IEvent e, bool isNew=false){ switch(e){ case UserRegistered ur: Email=ur.Email; break; case EmailChanged ec: Email=ec.Email; break; } if(isNew) Changes.Add(e); } }
