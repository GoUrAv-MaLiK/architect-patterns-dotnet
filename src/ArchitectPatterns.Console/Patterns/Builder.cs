namespace ArchitectPatterns.ConsoleApp.Patterns;
public sealed class Report { public string? Title; public string? Body; public string? Footer; }
public sealed class ReportBuilder { private readonly Report _r=new(); public ReportBuilder Title(string t){ _r.Title=t; return this;} public ReportBuilder Body(string b){ _r.Body=b; return this;} public ReportBuilder Footer(string f){ _r.Footer=f; return this;} public Report Build()=>_r; }
