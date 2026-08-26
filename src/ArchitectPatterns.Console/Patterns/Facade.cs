namespace ArchitectPatterns.ConsoleApp.Patterns;
public sealed class VideoEncoder{ public void Encode(string path){} }
public sealed class CdnUploader{ public void Upload(string path){} }
public sealed class MediaService{ private readonly VideoEncoder _e=new(); private readonly CdnUploader _u=new(); public void TranscodeAndPublish(string path){ _e.Encode(path); _u.Upload(path); } }
