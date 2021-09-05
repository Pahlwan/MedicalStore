using MedicalStore.Repository;
using MedicalStore.Domain;
using System.Linq;
using System;
using System.Collections.Generic;

namespace MedicalStore.Repository
{
    public interface IMedicineRepository:IRepository<Medicine>
    {
        Medicine GetMedicinByName(string name);
        IEnumerable<Medicine> GetMedicinesBySalts(string salt);
        IEnumerable<Medicine> GetMedicinesByMfd(DateTime mdf);
        IEnumerable<Medicine> GetMedicinesByExpiry(DateTime expiry);
    }
}
