# Builder Pattern

What it is:
Construct complex objects step by step; separate construction from representation.

When to use:
- Object has many optional parts
- Need readable, incremental construction

C# example:
public sealed class Report { public string Title; public string Body; public string Footer; }
public sealed class ReportBuilder { private readonly Report _r=new(); public ReportBuilder Title(string t){ _r.Title=t; return this;} public ReportBuilder Body(string b){ _r.Body=b; return this;} public ReportBuilder Footer(string f){ _r.Footer=f; return this;} public Report Build()=>_r; }

Java example:
final class Report { String title; String body; String footer; }
final class ReportBuilder { private final Report r=new Report(); ReportBuilder title(String t){ r.title=t; return this;} ReportBuilder body(String b){ r.body=b; return this;} ReportBuilder footer(String f){ r.footer=f; return this;} Report build(){ return r; } }

Architect terms:
- Fluent APIs
- Immutability (optional final step)
- Readability over telescoping constructors
