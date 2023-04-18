using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureCompany
{
    public partial class WorkerForm : Form
    {
        public WorkerForm(Worker worker)
        {
            InitializeComponent();
            textBoxId.Text = worker.Id.ToString();
            textBoxName.Text = worker.Name;
            textBoxSurname.Text = worker.Surname;
            textBoxAdress.Text = worker.Adress;
            textBoxNumber.Text = worker.Phone;
        }
    }
}
