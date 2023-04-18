using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureCompany
{
    public partial class AddProductForm : Form
    {
        private List<Manufacturer> _manufacturers;
        private List<Category> _categories;

        public AddProductForm(List<Manufacturer> manufacturers, List<Category> categories)
        {
            InitializeComponent();
            _manufacturers = manufacturers;
            _categories = categories;

            foreach (Manufacturer manufacturer in _manufacturers)
                comboBoxManuf.Items.Add(manufacturer);

            comboBoxManuf.SelectedIndex = 0;
            comboBoxManuf.ValueMember = "Name";

            foreach (Category category in _categories)
                comboBoxCategory.Items.Add(category);

            comboBoxCategory.SelectedIndex = 0;
            comboBoxCategory.ValueMember = "Name";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Images (*.jpg)|*.jpg|PNG Images (*.png)|*.png|All Files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog.FileName;
                    string destPath = Path.Combine(Application.StartupPath, "Images", Path.GetFileName(fileName));
                    File.Copy(fileName, destPath, true);
                    textBoxImage.Text = Path.GetFileName(fileName);
                    pictureBox.ImageLocation = openFileDialog.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            long count = decimal.ToInt64(numericUpDownCount.Value);
            long price = decimal.ToInt64(numericUpDownPrice.Value);
            string desc = textBoxDesc.Text;

            Manufacturer manufacturer = comboBoxManuf.SelectedItem as Manufacturer;
            Category category = comboBoxCategory.SelectedItem as Category;

            string query = "INSERT INTO product " +
                "(Name, Count, Price, Image, Desc, ManufacturerId, CategoryId) " +
                "VALUES(@Name, @Count, @Price, @Image, @Desc, @ManufacturerId, @CategoryId); ";
            SQLiteReaderHelper.Request(query, name, count, price, textBoxImage.Text, desc, 
                manufacturer.Id, category.Id);
            MessageBox.Show("Продукт додано!");
            this.Close();
        }

        private void buttonAddManuf_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
