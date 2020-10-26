using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalTrackingSystem_Backend.Data
{
    public static class Data
    {
        public static List<Medicine> Medicines => allMedicine;
        static List<Medicine> allMedicine = GetMedicinesFromJson();
        static List<Medicine> GetMedicinesFromJson()
        {
            var jsonString = File.ReadAllText(@".\Data\mts.json");
            return JsonConvert.DeserializeObject<List<Medicine>>(jsonString);
        }
    }
}
