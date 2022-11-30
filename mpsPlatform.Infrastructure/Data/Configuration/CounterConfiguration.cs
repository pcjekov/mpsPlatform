using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;
using System.Globalization;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class CounterConfiguration : IEntityTypeConfiguration<Counter>
    {
        public void Configure(EntityTypeBuilder<Counter> builder)
        {
            builder.HasData(CreateCounter());
        }

        private List<Counter> CreateCounter()
        {
            List<Counter> counters = new List<Counter>()
            {
                new Counter()
                {
                    Id = 1,
                    MonochromeA4 = 95000,
                    MonochromeA3 = 900,
                    ColorA4 = 336300,
                    ColorA3 = 4670,
                    SerialNumberId = 1,
                    DateOfCounter = DateTime.Parse("08.11.2022", CultureInfo.InvariantCulture),
                },

                new Counter()
                {
                    Id = 2,
                    MonochromeA4 = 4700,
                    MonochromeA3 = 10,
                    ColorA4 = 35800,
                    ColorA3 = 390,
                    SerialNumberId = 2,
                    DateOfCounter = DateTime.Parse("08.11.2022", CultureInfo.InvariantCulture),
                },

                new Counter()
                {
                    Id = 3,
                    MonochromeA4 = 58400,
                    SerialNumberId = 3,
                    DateOfCounter = DateTime.Parse("08.11.2022", CultureInfo.InvariantCulture),
                },

                new Counter()
                {
                    Id = 4,
                    MonochromeA4 = 94700,
                    SerialNumberId = 4,
                    DateOfCounter = DateTime.Parse("09.11.2022", CultureInfo.InvariantCulture),
                },

                new Counter()
                {
                    Id = 5,
                    MonochromeA4 = 232100,
                    SerialNumberId = 5,
                    DateOfCounter = DateTime.Parse("09.11.2022", CultureInfo.InvariantCulture),
                },

                new Counter()
                {
                    Id = 6,
                    MonochromeA4 = 137200,
                    SerialNumberId = 6,
                    DateOfCounter = DateTime.Parse("07.10.2022", CultureInfo.InvariantCulture),
                }

            };

            return counters;
        }
    }
}

