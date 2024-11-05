using ENSEKTask.Data.MeterReadings;

namespace ENSEKTask.Models.Interfaces
{
    public interface IDbHelper
    {
        public int LogReadings_ReturnsSuccesses(IEnumerable<MeterReading> readings, MeterReadingsDbContext context);
    }
}
