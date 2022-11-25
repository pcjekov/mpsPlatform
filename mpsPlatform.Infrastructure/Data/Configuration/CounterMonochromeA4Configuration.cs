using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class CounterMonochromeA4Configuration : IEntityTypeConfiguration<CounterMonochromeA4>
    {
        public void Configure(EntityTypeBuilder<CounterMonochromeA4> builder)
        {
            builder.HasData(CreateCounterMonochromeA4());
        }

        private List<CounterMonochromeA4> CreateCounterMonochromeA4()
        {
            List<CounterMonochromeA4> counters = new List<CounterMonochromeA4>()
            {
                new CounterMonochromeA4()
                {
                    Id = 1,
                    CurrentCounter = 95000,
                    SerialNumberId = 1,
                    DateOfEntryId = 1,
                },

                new CounterMonochromeA4()
                {
                    Id = 2,
                    CurrentCounter = 4700,
                    SerialNumberId = 2,
                    DateOfEntryId = 1,
                },

                new CounterMonochromeA4()
                {
                    Id = 3,
                    CurrentCounter = 58400,
                    SerialNumberId = 3,
                    DateOfEntryId = 1,
                },

                new CounterMonochromeA4()
                {
                    Id = 4,
                    CurrentCounter = 94700,
                    SerialNumberId = 4,
                    DateOfEntryId = 2,
                },

                new CounterMonochromeA4()
                {
                    Id = 5,
                    CurrentCounter = 232100,
                    SerialNumberId = 5,
                    DateOfEntryId = 2,
                },

                new CounterMonochromeA4()
                {
                    Id = 6,
                    CurrentCounter = 137200,
                    SerialNumberId = 6,
                    DateOfEntryId = 3,
                }

            };

            return counters;
        }
    }
}

