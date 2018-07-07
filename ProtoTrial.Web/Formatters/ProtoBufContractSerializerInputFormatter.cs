using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ProtoTrial.Web.Formatters
{
    internal class ProtoBufContractSerializerInputFormatter : InputFormatter
    {
        public ProtoBufContractSerializerInputFormatter()
        {
            SupportedMediaTypes.Add(Dto.MediaType.ProtoBuf.MediaType);
            SupportedMediaTypes.Add(Dto.MediaType.ProtoBufBase64.MediaType);
        }
        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            var request = context.HttpContext.Request;
            var contentType = context.HttpContext.Request.ContentType;

            Stream stream;

            if (context.HttpContext.Request.ContentType.Contains("base64", StringComparison.OrdinalIgnoreCase))
            {
                using (var reader = new StreamReader(request.Body))
                {
                    var content = await reader.ReadToEndAsync();
                    stream = new MemoryStream(Convert.FromBase64String(content));
                }
            }
            else
            {
                stream = context.HttpContext.Request.Body;
            }

            var o = ProtoBuf.Serializer.Deserialize(context.ModelType, stream);
            return await InputFormatterResult.SuccessAsync(o);
        }
    }
}