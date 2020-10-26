using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalTrackingSystem_Backend.Data
{
    public interface IMTSService
    {
        List<Medicine> GetAllMedicines();

        Medicine GetMedicineById(string id);

        void UpdateMedicine(string id, Medicine newMedicine);

        void DeleteMedicine(string id);


        void AddMedicine(Medicine newMedicine);
    }
}
