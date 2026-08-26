# CQRS

What it is:
Separate writes (commands) from reads (queries) with different models/handlers for each path.

When to use:
- High read/write asymmetry
- Independent scaling and validation paths

Code
- C#: `src/ArchitectPatterns.Console/Patterns/Cqrs.cs`
