using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStore.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        IMedicineRepository Medicines { get; }
    }
}
