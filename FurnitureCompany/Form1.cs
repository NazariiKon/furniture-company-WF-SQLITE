using System.Data.SQLite;
using System.Drawing;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FurnitureCompany
{
    public partial class Form1 : Form
    {
        List<Product> products;
        List<Category> categories;
        List<Manufacturer> manufacturers;
        Product selectedProduct = null;

        public Form1(string email)
        {
            InitializeComponent();
            categories = new List<Category>();
            products = readAllProducts();
            readAllCategories();
            readAllManufacturers();
        }

        private void readAllManufacturers()
        {
            manufacturers = new List<Manufacturer>();
            string query = "SELECT * FROM manufacturer";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query);
            while (reader.Read()) // построчно считываем данные
            {
                manufacturers.Add(CreateObject<Manufacturer>(reader,
                                                "Id",
                                                "Name",
                                                "Adress",
                                                "Phone"));
            }
        }

        private void readAllCategories()
        {
            string query = "SELECT * FROM category";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query);
            while (reader.Read()) // построчно считываем данные
            {
                Category category = CreateObject<Category>(reader, "Id", "Name", "Desc");
                category.Products = new List<Product>();
                // —оздание корневого узла
                TreeNode rootNode = new TreeNode(category.Name);
                // ƒобавление узлов в корневой узел
                foreach (Product product in products)
                {
                    if (category.Id == product.CategoryId)
                    {
                        category.Products.Add(product);
                        rootNode.Nodes.Add(new TreeNode(product.Name));
                    }
                }
                categories.Add(category);

                // ƒобавление корневого узла в элемент TreeView
                catalogueTreeView.Nodes.Add(rootNode);
            }
        }

        private List<Product> readAllProducts()
        {
            products = new List<Product>();
            string query = "SELECT * FROM product";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query);
            while (reader.Read()) // построчно считываем данные
            {
                products.Add(CreateObject<Product>(reader,
                                                "Id",
                                                "Name",
                                                "Count",
                                                "Price",
                                                "Image",
                                                "Desc",
                                                "ManufacturerId",
                                                "CategoryId"));
            }
            return products;
        }

        private void catalogueTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (Product product in products)
            {
                if (product.Name == catalogueTreeView.SelectedNode.Text)
                {
                    string destPath = Path.Combine(Application.StartupPath, "Images", Path.GetFileName(product.Image));
                    pictureBox.ImageLocation = destPath;
                    labelName.Text = product.Name;
                    labelDesc.Text = product.Desc;
                    labelPrice.Text = product.Price.ToString();
                    selectedProduct = product;
                }
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            // form buy the product
            BuyProductForm form = new BuyProductForm();
            form.Show();
        }

        private void buttonManufacture_Click(object sender, EventArgs e)
        {
            foreach (Manufacturer manufacturer in manufacturers)
            {
                if (selectedProduct.ManufacturerId == manufacturer.Id)
                {
                    ManufactureForm manufactureForm = new ManufactureForm(manufacturer);
                    manufactureForm.Show();
                }
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // form add product
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            // form add category
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            // form orders
        }

        public T CreateObject<T>(SQLiteDataReader reader, params object[] args) where T : new()
        {
            T obj = new T();
            Type type = typeof(T);
            for (int i = 0; i < args.Length; i++)
            {
                PropertyInfo prop = type.GetProperty(args[i].ToString());
                if (prop != null)
                {
                    prop.SetValue(obj, reader.GetValue(i));
                }
            }
            return obj;
        }
    }

}
