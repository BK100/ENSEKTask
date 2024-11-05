using ENSEKTask.Data.Accounts;

namespace ENSEKTask.Models.Interfaces
{
    public interface IFileParser
    {
        public IEnumerable<MeterReading> Parse(string inputCsv);
    }
}
