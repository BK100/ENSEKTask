namespace ENSEKClient.Models.Interfaces
{
    public interface IHTTPHelper
    {
        public Task<MeterReadingResponse> UploadCSV(HttpClient client, string csv);
    }
}
