# Facade Pattern

What it is:
Provide a simple API over a complex set of subsystems.

When to use:
- Hide multi-step workflows
- Provide stable boundary to clients

C# example:
public sealed class VideoEncoder{ public void Encode(string path){} }
public sealed class CdnUploader{ public void Upload(string path){} }
public sealed class MediaService{ private readonly VideoEncoder _e=new(); private readonly CdnUploader _u=new(); public void TranscodeAndPublish(string path){ _e.Encode(path); _u.Upload(path); } }

Architect terms:
- API surface minimization
- Encapsulation of orchestration

## Code
- C#: [Facade.cs](../../src/ArchitectPatterns.Console/Patterns/Facade.cs)

