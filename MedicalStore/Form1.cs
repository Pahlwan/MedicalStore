using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalStore.Domain;
using MedicalStore.Repository;

namespace MedicalStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PlutoContext());
            foreach(Medicine medicine in  unitOfWork.Medicines.GetAll())
            {
                
                datagridviewMedicine.Rows.Add(medicine.Id, medicine.Name, medicine.Mfd, medicine.Expiry);
            }
            
        }
    }
}
