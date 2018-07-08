using ProtoBuf;

namespace ProtoTrial.Dto
{
    [ProtoContract]
    public class Rocket :ProtobufEntity
    {
        [ProtoMember(1)]
        public int Value { get; set; }


        [ProtoMember(2)]
        public int Diameter { get; set; }
    }
}
