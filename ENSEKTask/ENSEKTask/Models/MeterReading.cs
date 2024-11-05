using CsvHelper.Configuration.Attributes;

namespace ENSEKTask.Models
{
    public class MeterReading
    {
        public int? ReadingId {  get; set; }
        [Name("AccountId")]
        public int AccountId { get; set; }
        [Name("MeterReadValue")]
        public int MeterReadValue { get; set; }
        [Name("MeterReadingDateTime")]
        public string MeterReadingDateTime { get; set; } = string.Empty;
    }
}
