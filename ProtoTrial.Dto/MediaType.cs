using System.Net.Http.Headers;

namespace ProtoTrial.Dto
{
    public static class MediaType
    {
        public static MediaTypeHeaderValue ProtoBuf = new MediaTypeHeaderValue("application/protobuf");
        public static MediaTypeHeaderValue ProtoBufBase64 = new MediaTypeHeaderValue("application/protobuf+base64");

    }
}
