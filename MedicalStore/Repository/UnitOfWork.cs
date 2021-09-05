using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStore.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            Medicines = new MedicineRepository(context);
        }

        public IMedicineRepository Medicines { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
