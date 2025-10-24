using System;
using System.IO;
using System.Runtime.Serialization;

namespace Python.Runtime;

#pragma warning disable SYSLIB0011 // Type or member is obsolete
public class NoopFormatter : IFormatter {
#pragma warning restore SYSLIB0011 // Type or member is obsolete
    public object Deserialize(Stream s) => throw new NotImplementedException();
    public void Serialize(Stream s, object o) {}

    public SerializationBinder? Binder { get; set; }
    public StreamingContext Context { get; set; }
    public ISurrogateSelector? SurrogateSelector { get; set; }
}
