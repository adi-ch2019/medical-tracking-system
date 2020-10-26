using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicaltrackingsystem.api.Data
{
    public class Medicine
    {
          public string FullNameOfMedicine { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public DateTime ExpiryDate { get; set; }
        public string Notes { get; set; }
    }
}
