using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class CounterMonochromeA3Configuration : IEntityTypeConfiguration<CounterMonochromeA3>
    {
        public void Configure(EntityTypeBuilder<CounterMonochromeA3> builder)
        {
            builder.HasData(CreateCounterMonochromeA3());
        }

        private List<CounterMonochromeA3> CreateCounterMonochromeA3()
        {
            List<CounterMonochromeA3> counters = new List<CounterMonochromeA3>()
            {
                new CounterMonochromeA3()
                {
                    Id = 1,
                    CurrentCounter = 900,
                    SerialNumberId = 1,
                    DateOfEntryId = 1,
                },

                new CounterMonochromeA3()
                {
                    Id = 2,
                    CurrentCounter = 10,
                    SerialNumberId = 2,
                    DateOfEntryId = 1,
                }

            };

            return counters;
        }
    }
}
