using ENSEKTask.Models;
using Microsoft.EntityFrameworkCore;

namespace ENSEKTask.Data.MeterReadings
{
    public class MeterReadingsDbContext : DbContext
    {
        public DbSet<MeterReading> Readings { get; set; }

        public MeterReadingsDbContext(DbContextOptions<MeterReadingsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeterReading>(entity =>
            {
                entity.HasKey(e => e.ReadingId);
                entity.Property(e => e.ReadingId);
                entity.Property(e => e.AccountId);
                entity.Property(e => e.MeterReadingDateTime);
                entity.Property(e => e.MeterReadValue);
            });
        }
    }
}
