using System.ComponentModel.DataAnnotations;

namespace mpsPlatform.Infrastructure.Data.Models
{
    public class DateOfEntry
    {
        public DateOfEntry()
        {
            CountersMonochromeA4 = new List<CounterMonochromeA4>();
            CountersMonochromeA3 = new List<CounterMonochromeA3>();
            CountersColorA4 = new List<CounterColorA4>();
            CountersColorA3 = new List<CounterColorA3>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public List<CounterMonochromeA4> CountersMonochromeA4 { get; set; }
        public List<CounterMonochromeA3> CountersMonochromeA3 { get; set; }
        public List<CounterColorA4> CountersColorA4 { get; set; }
        public List<CounterColorA3> CountersColorA3 { get; set; }
    }
}
