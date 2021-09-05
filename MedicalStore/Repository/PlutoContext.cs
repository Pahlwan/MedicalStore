using System;
using System.Data.Entity;
using MedicalStore.Domain;

namespace MedicalStore.Repository
{
    public class PlutoContext:DbContext
    {
        public PlutoContext():base("Server=localhost;Database=;Uid=root;Pwd=3010")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Medicine> Medicines { get; set; }
    }
}
