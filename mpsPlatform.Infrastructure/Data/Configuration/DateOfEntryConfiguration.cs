using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;
using System.Globalization;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class DateOfEntryConfiguration : IEntityTypeConfiguration<DateOfEntry>
    {
        public void Configure(EntityTypeBuilder<DateOfEntry> builder)
        {
            builder.HasData(CreateDateOfEntry());
        }

        private List<DateOfEntry> CreateDateOfEntry()
        {
            List<DateOfEntry> dates = new List<DateOfEntry>()
            {
                new DateOfEntry()
                {
                    Id = 1,
                    Date = DateTime.Parse("08.11.2022", CultureInfo.InvariantCulture)
                },

                new DateOfEntry()
                {
                    Id = 2,
                    Date = DateTime.Parse("09.11.2022", CultureInfo.InvariantCulture)
                },

                new DateOfEntry()
                {
                    Id = 3,
                    Date = DateTime.Parse("07.10.2022", CultureInfo.InvariantCulture)
                },

                new DateOfEntry()
                {
                    Id = 4,
                    Date = DateTime.Parse("07.11.2022", CultureInfo.InvariantCulture)
                }

            };
            return dates;
        }
    }
}
