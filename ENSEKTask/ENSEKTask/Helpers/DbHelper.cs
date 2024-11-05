using ENSEKTask.Data.MeterReadings;
using ENSEKTask.Models;
using ENSEKTask.Models.Interfaces;

namespace ENSEKTask.Helpers
{
    public class DbHelper : IDbHelper
    {
        public int LogReadings_ReturnsSuccesses(IEnumerable<MeterReading> readings, MeterReadingsDbContext context)
        {
            foreach (MeterReading reading in readings)
            {
                context.Readings.Update(new MeterReading()
                {
                    AccountId = reading.AccountId,
                    MeterReadingDateTime = reading.MeterReadingDateTime,
                    MeterReadValue = reading.MeterReadValue
                });
                context.SaveChanges();
            }
            return readings.Count();
        }
    }
}
