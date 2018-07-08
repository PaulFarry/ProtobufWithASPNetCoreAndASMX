using ProtoTrial.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoTrial.Test
{
    public partial class Form1 : Form
    {

        HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44364/api/")
            };
        }

        private void btnRocket_Click(object sender, EventArgs e)
        {
            var rocket = new Rocket
            {
                Diameter = 51,
                Value = 314159
            };

            var h = Create("rockets", rocket);
            var response = httpClient.SendAsync(h).Result;
            ProcessResponse(response);

        }

        private void btnSatellite_Click(object sender, EventArgs e)
        {
            var satellite = new Satellite
            {
                LaunchWeight = 21.52,
                SolarCells = 129,
                CrewMembers = new List<string>{
                "john", "fred", "sharon"
                }
            };

            var h = Create("satellite", satellite);
            var response = httpClient.SendAsync(h).Result;
            ProcessResponse(response);
        }

        private void ProcessResponse(HttpResponseMessage response)
        {
            txtResponseStatus.Text = $"{(int)response.StatusCode} {response.ReasonPhrase}";
            
            txtResponse.Text = response.Content.ReadAsStringAsync().Result;
        }


        private HttpRequestMessage Create(string address, object toSerialise)
        {
            var h = new HttpRequestMessage(HttpMethod.Post, address);

            using (var ms = new MemoryStream())
            {
                ProtoBuf.Serializer.Serialize(ms, toSerialise);
                var buffer = ms.ToArray();

                var byteContent = new ByteArrayContent(buffer);
                if (chkDumpBase64.Checked)
                {
                    var s = Convert.ToBase64String(buffer);
                    txtBase64.Text = s;
                }
                byteContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/protobuf");

                h.Content = byteContent;
            }

            if (rdoJson.Checked)
            {
                h.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

            if (rdoProtobuf.Checked)
            {
                h.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaType.ProtoBuf.MediaType));
            }

            if (rdoProtobufBase64.Checked)
            {
                h.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaType.ProtoBufBase64.MediaType));
            }

            return h;
        }

        private void btnASMXTest_Click(object sender, EventArgs e)
        {
            try
            {

                var ss = new MyService.WebServiceSoapClient("WebServiceSoap");
                var result = ss.HelloWorld();
            }


            catch (Exception ex)
            {
                Debug.Print($"{ex}");
            }
        }

    }
}
