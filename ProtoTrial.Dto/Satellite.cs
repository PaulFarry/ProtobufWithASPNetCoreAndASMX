using ProtoBuf;
using System.Collections.Generic;

namespace ProtoTrial.Dto
{
    [ProtoContract(UseProtoMembersOnly = true)]
    public class Satellite : ProtobufEntity
    {
        [ProtoMember(1)]
        public int SolarCells { get; set; }

        [ProtoMember(2)]
        public double LaunchWeight { get; set; }

        [ProtoMember(3)]
        public List<string> CrewMembers { get; set; }
    }
}
