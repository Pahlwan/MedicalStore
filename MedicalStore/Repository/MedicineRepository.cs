using System;
using System.Collections.Generic;
using MedicalStore.Domain;
using System.Linq;

namespace MedicalStore.Repository
{
    public class MedicineRepository : Repository<Medicine>, IMedicineRepository
    {

        public MedicineRepository(PlutoContext context):base(context)
        {

        }

        public Medicine GetMedicinByName(string name)
        {
            return PlutoContext.Medicines.Where(n => n.Name == name).FirstOrDefault();
        }

        public IEnumerable<Medicine> GetMedicinesByExpiry(DateTime expiry)
        {
            return PlutoContext.Medicines.Where(m => m.Expiry < expiry);
        }

        public IEnumerable<Medicine> GetMedicinesByMfd(DateTime mfd)
        {
            return PlutoContext.Medicines.Where(m => m.Mfd < mfd);
        }

        public IEnumerable<Medicine> GetMedicinesBySalts(string salt)
        {
            return PlutoContext.Medicines.Where(m => m.Salts.Contains(salt));
        }

        private PlutoContext PlutoContext
        {
            get { return this.Context as PlutoContext; }
        }
    }
}
