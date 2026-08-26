namespace ArchitectPatterns.ConsoleApp.Patterns;
public interface IImage { void Render(); }
public sealed class Image : IImage { public void Render(){ } }
public sealed class LazyImageProxy : IImage { private IImage? _real; public void Render(){ _real ??= new Image(); _real.Render(); } }
