using System; using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface IRequest<R>{ }
public interface IRequestHandler<T,R> where T:IRequest<R>{ R Handle(T request); }
public sealed class Mediator { private readonly Dictionary<Type,object> _handlers=new(); public void Register<T,R>(IRequestHandler<T,R> h) where T:IRequest<R>{ _handlers[typeof(T)]=h; } public R Send<T,R>(T request) where T:IRequest<R>{ var h=(IRequestHandler<T,R>)_handlers[typeof(T)]; return h.Handle(request); } }
