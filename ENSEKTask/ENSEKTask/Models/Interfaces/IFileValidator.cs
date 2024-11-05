using ENSEKTask.Data.Accounts;
using ENSEKTask.Data.MeterReadings;

namespace ENSEKTask.Models.Interfaces
{
    public interface IFileValidator
    {
        public IEnumerable<MeterReading> Validate(IEnumerable<MeterReading> readings, AccountsDbContext accContext, MeterReadingsDbContext mrContext);
    }
}
