using System.Collections.Generic;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface IObserver{ void OnPriceChanged(decimal price); }
public sealed class Ticker{ private readonly List<IObserver> _obs=new(); public void Subscribe(IObserver o)=>_obs.Add(o); public void Price(decimal p){ foreach(var o in _obs) o.OnPriceChanged(p);} }
