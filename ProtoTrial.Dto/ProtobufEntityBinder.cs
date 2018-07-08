using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Threading.Tasks;

namespace ProtoTrial.Web.Binders
{
    public class ProtobufEntityBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var r = bindingContext.HttpContext;
            if (r.Request.ContentLength == 0)
            {

                if (r.Request.ContentType == Dto.MediaType.ProtoBuf.MediaType || r.Request.ContentType == Dto.MediaType.ProtoBufBase64.MediaType)
                {
                    bindingContext.Result = ModelBindingResult.Success(Activator.CreateInstance(bindingContext.ModelType));
                    return Task.CompletedTask;
                }
                bindingContext.Result = ModelBindingResult.Failed();
                return Task.FromResult(0);
            }
            return Task.CompletedTask;
        }
    }
}
