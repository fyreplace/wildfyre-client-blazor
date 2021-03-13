#nullable enable

using Refit;

namespace Ynferno.Models
{
    public struct ImageData
    {
        public string Name { get; set; }
        public string Mime { get; set; }
        public byte[] Data { get; set; }

        public ByteArrayPart AsByteArrayPart() => new(Data, Name, Mime);
    }
}
