using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalTrackingSystem_Backend.Data
{
    public class Medicine
    {
          public string FullNameOfMedicine { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }

        public string ExpiryDate { get; set; }
        public string Notes { get; set; }
    }
}
