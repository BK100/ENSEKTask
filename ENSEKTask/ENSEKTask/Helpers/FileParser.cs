using CsvHelper;
using CsvHelper.Configuration;
using ENSEKTask.Data.Accounts;
using ENSEKTask.Models;
using ENSEKTask.Models.Interfaces;
using System.Globalization;

namespace ENSEKTask.Helpers
{
    public class FileParser : IFileParser
    {
        public IEnumerable<MeterReading> Parse(string inputCsv)
        {
            IEnumerable<MeterReading> readings;

            using (var sReader = new StringReader(inputCsv))
            {
                using (var csvReader = new CsvReader(sReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<ReadingMap>();
                    readings = csvReader.GetRecords<MeterReading>().ToList();
                }
            }

            if (readings == null) throw new Exception("Unable to parse CSV file.");

            return readings;
        }

        private sealed class ReadingMap : ClassMap<MeterReading>
        {
            public ReadingMap()
            {
                AutoMap(CultureInfo.InvariantCulture);
                Map(m => m.ReadingId).Ignore();
            }
        }
    }
}
