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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SQLiteDataReader reader = SQLiteReaderHelper.Request
                ("SELECT * FROM client WHERE Email = @param", textBoxEmail.Text);
            if (reader != null)
            {
                Form1 newForm1 = null;
                while (reader.Read())
                {
                    newForm1 = new Form1(SQLiteReaderHelper.CreateObject<Client>(reader,
                                                "Id",
                                                "Name",
                                                "Surname",
                                                "Login",
                                                "Password",
                                                "Email",
                                                "Adress",
                                                "Phone"));
                }
               
                newForm1.Show();
                reader.Close();
            }
            else
            {
                MessageBox.Show("Невірний Email", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
