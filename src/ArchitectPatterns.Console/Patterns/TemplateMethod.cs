namespace ArchitectPatterns.ConsoleApp.Patterns;
public abstract class DataExporter { public string Export(){ var d=Read(); d=Transform(d); return Write(d); } protected abstract string Read(); protected virtual string Transform(string d)=>d; protected abstract string Write(string d); }
