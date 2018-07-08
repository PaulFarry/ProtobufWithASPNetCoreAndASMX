using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ProtoTrial.Web.Formatters
{
    internal class ProtobufOutputFormatter : OutputFormatter
    {
        public ProtobufOutputFormatter()
        {
            SupportedMediaTypes.Add(Dto.MediaType.ProtoBuf.MediaType);
            SupportedMediaTypes.Add(Dto.MediaType.ProtoBufBase64.MediaType);
        }

        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context)
        {
            var response = context.HttpContext.Response;

            var contentType = context.HttpContext.Request.Headers["Accept"][0];
            if (contentType.Contains("base64", StringComparison.OrdinalIgnoreCase))
            {
                using (var ms = new MemoryStream())
                {
                    ProtoBuf.Serializer.Serialize(ms, context.Object);

                    var output = Convert.ToBase64String(ms.ToArray());
                    using (var writer = context.WriterFactory(response.Body, System.Text.Encoding.UTF8))
                    {
                        writer.Write(output);
                        return writer.FlushAsync();
                    }
                }
            }
            else
            {
                ProtoBuf.Serializer.Serialize(response.Body, context.Object);
                return Task.FromResult(response);
            }
        }
    }
}
