using System.Text.Json;
using System.Text;
using ENSEKClient.Models.Interfaces;
using ENSEKClient.Models;
using System.Web;
using System.Text.RegularExpressions;

namespace ENSEKClient.Helpers
{
    public class HTTPHelper : IHTTPHelper
    {
        public async Task<MeterReadingResponse> UploadCSV(HttpClient client, string csv)
        {
            var request = new MeterReadingRequest()
            {
                inputCsv = csv
            };
            var requestData = JsonSerializer.Serialize(request);
            var httpRequestBody = new StringContent(requestData, Encoding.UTF8, "application/json");

            var result = await client.PostAsync("https://localhost:44315/meter-reading-uploads", httpRequestBody);

            var response = JsonSerializer.Deserialize<MeterReadingResponse>(await result.Content.ReadAsStringAsync());

            return response;
        }
    }
}
