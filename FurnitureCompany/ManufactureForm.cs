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
    public partial class ManufactureForm : Form
    {
        public ManufactureForm(Manufacturer manufacturer)
        {
            InitializeComponent();
            labelName.Text = manufacturer.Name;
            labelAddress.Text = manufacturer.Adress;
            labelPhone.Text = manufacturer.Phone;
        }
    }
}
