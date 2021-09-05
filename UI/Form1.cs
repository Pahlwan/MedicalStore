using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models.Entity;
using Services.Common;

namespace UI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.BirthDate = DateTime.Parse(textBox.Text.Trim());

            ModelValidation<Person> modelValidation = new ModelValidation<Person>();
            try
            {
                modelValidation.ValidateDataAnotation(person);
            }
            catch(Exception ex)
            {
                labelError.Text = ex.Message;
            }
            
        }
    }
}
