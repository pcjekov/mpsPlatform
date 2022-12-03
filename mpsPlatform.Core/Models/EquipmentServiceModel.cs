using mpsPlatform.Core.Models;
using System.Collections.Generic;

namespace mpsPlatform.Models
{
    public class EquipmentServiceModel
    {
        public int Id { get; set; }

        public string ManufacturerName { get; set; } = null!;

        public string EquipmentModelName { get; set; } = null!;

        public string CustomerName { get; set; } = null!;

        public string ContractNumber { get; set; } = null!;

        public string LocationName { get; set; } = null!;
        
        public string SerialNumber { get; set; } = null!;

        public DateTime Date { get; set; }

        public int Counter { get; set; }

    }
}
