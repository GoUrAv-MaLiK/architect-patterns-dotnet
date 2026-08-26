using System;
namespace ArchitectPatterns.ConsoleApp.Patterns;
public sealed class Config { private static readonly Lazy<Config> _i=new(()=>new Config()); public static Config Instance=>_i.Value; private Config(){} }
