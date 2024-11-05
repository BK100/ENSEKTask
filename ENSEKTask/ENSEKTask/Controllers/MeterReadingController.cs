using CsvHelper;
using ENSEKTask.Data.Accounts;
using ENSEKTask.Data.MeterReadings;
using ENSEKTask.Models;
using ENSEKTask.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ENSEKTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeterReadingController : ControllerBase
    {
        private readonly IDbHelper _dbHelper;
        private readonly IFileParser _parser;
        private readonly IFileValidator _validator;

        private readonly AccountsDbContext _accountsDbContext;
        private readonly MeterReadingsDbContext _meterReadingsDbContext;

        public MeterReadingController(IDbHelper dbHelper, IFileParser parser, IFileValidator validator, AccountsDbContext accountsDbContext, MeterReadingsDbContext meterReadingsDbContext)
        {
            _dbHelper = dbHelper;
            _parser = parser;
            _validator = validator;
            _accountsDbContext = accountsDbContext;
            _meterReadingsDbContext = meterReadingsDbContext;
        }

        [HttpPost]
        [Route("/meter-reading-uploads")]
        public MeterReadingResponse ProcessReadings([FromBody] MeterReadingRequest request)
        {
            var readings = _parser.Parse(request.inputCsv);
            var validatedReadings = _validator.Validate(readings, _accountsDbContext, _meterReadingsDbContext);
            var successfulReadings = _dbHelper.LogReadings_ReturnsSuccesses(validatedReadings, _meterReadingsDbContext);

            return GetResponse(successfulReadings, readings.Count());
        }

        private Func<int, int, MeterReadingResponse> GetResponse = (x, y) => new MeterReadingResponse() { SuccessfulReadings = x, FailedReadings = y - x };
    }
}
