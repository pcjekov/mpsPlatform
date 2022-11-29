using mpsPlatform.Core.Models;
using System.Collections.Generic;

namespace mpsPlatform.Models
{
    public class EquipmentServiceModel
    {
        public int Id { get; set; }

        public string ManifacturerName { get; set; } = null!;

        public string EquipmentModelName { get; set; } = null!;

        public string CustomerName { get; set; } = null!;

        public string ContractNumber { get; set; } = null!;

        public string LocationName { get; set; } = null!;
        
        public string SerialNumber { get; set; } = null!;

        public IEnumerable<EquipmentServiceCounterDateModel> CountersDates { get; set; }
        //public DateTime Date { get; set; }
        ////public string Date { get; set; } = null!;


        //public int CurrentCounter { get; set; }

    }
}
