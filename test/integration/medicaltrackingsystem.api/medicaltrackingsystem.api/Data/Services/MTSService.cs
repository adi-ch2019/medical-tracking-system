using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicaltrackingsystem.api.Data
{
    public class MTSService:IMTSService
    {

        public void AddMedicine(Medicine newMedicine)
        {
            Data.Medicines.Add(newMedicine);
            // throw new System.NotImplementedException();
        }

        public void DeleteMedicine(string id)
        {
            var Medicine = Data.Medicines.FirstOrDefault(n => n.FullNameOfMedicine == id);
            Data.Medicines.Remove(Medicine);
            //throw new System.NotImplementedException();
        }

        public List<Medicine> GetAllMedicines()
        {
            return Data.Medicines.ToList();
            //throw new System.NotImplementedException();
        }

        public Medicine GetMedicineById(string id)
        {
            return Data.Medicines.FirstOrDefault(n => n.FullNameOfMedicine == id);
            // throw new System.NotImplementedException();
        }

        public void UpdateMedicine(string id, Medicine newMedicine)
        {
            var oldMedicine = Data.Medicines.FirstOrDefault(n => n.FullNameOfMedicine == id);
            if (oldMedicine != null)
            {
                oldMedicine.Notes = newMedicine.Notes;
              
            }
            //throw new System.NotImplementedException();
        }
    }
}
