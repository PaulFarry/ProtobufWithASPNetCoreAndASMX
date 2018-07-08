using Microsoft.AspNetCore.Mvc;
using ProtoTrial.Web.Binders;

namespace ProtoTrial.Dto
{
    [ModelBinder(BinderType = typeof(ProtobufEntityBinder))]
    public abstract class ProtobufEntity
    {
    }
}
