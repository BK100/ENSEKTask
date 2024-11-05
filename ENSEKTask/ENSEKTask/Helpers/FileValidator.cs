using ENSEKTask.Data.Accounts;
using ENSEKTask.Data.MeterReadings;
using ENSEKTask.Models;
using ENSEKTask.Models.Interfaces;

namespace ENSEKTask.Helpers
{
    public class FileValidator : IFileValidator
    {
        public IEnumerable<MeterReading> Validate(IEnumerable<MeterReading> readings, AccountsDbContext accContext, MeterReadingsDbContext mrContext)
        {
            List<MeterReading> validatedReadings = new List<MeterReading>();

            foreach (MeterReading reading in readings)
            {
                if (CheckValueFormat(reading))
                {
                    if (CheckAccountId(reading, accContext))
                    {
                        if (!validatedReadings.Any(x => x == reading))
                        {
                            var mostRecent = true;
                            var readingDateTime = DateTime.Parse(reading.MeterReadingDateTime);

                            // Gets an IQueryable of existing readings for the account holder
                            var existingReadings = mrContext.Readings.Where(r => r.AccountId == reading.AccountId).ToList();

                            foreach (MeterReading existingReading in existingReadings)
                            {
                                // Checks if the reading being added is the most recent, the reading will not be inputted if false
                                var existingReadingDateTime = DateTime.Parse(existingReading.MeterReadingDateTime);
                                if (DateTime.Compare(existingReadingDateTime, readingDateTime) >= 0) mostRecent = false;
                            }

                            if (mostRecent)
                            {
                                validatedReadings.Add(reading);
                            };
                        }
                    }
                }
            }

            return validatedReadings;
        }

        public bool CheckAccountId(MeterReading reading, AccountsDbContext context)
        {
            bool accountExists = false;
                
            if(context.Accounts.Any(x => x.AccountId == reading.AccountId)) accountExists = true;

            return accountExists;
        }

        // Validation lambdas
        private Func<MeterReading, bool> CheckValueFormat = x => x.MeterReadValue > 0 && x.MeterReadValue.ToString().Length == 5;
    }
}
