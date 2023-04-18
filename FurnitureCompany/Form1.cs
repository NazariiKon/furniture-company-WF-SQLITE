using System.Data.SQLite;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FurnitureCompany
{
    public partial class Form1 : Form
    {
        List<Product> products;
        List<Category> categories;
        List<Manufacturer> manufacturers;
        List<Worker> workers;
        List<Client> clients;
        List<Order> orders = new List<Order>();
        Product selectedProduct = null;
        Client mainClient = null;

        public Form1(Client client)
        {
            mainClient = client;
            InitializeComponent();
            categories = new List<Category>();
            orders = readAllOrders();
            products = readAllProducts();
            readAllCategories();
            readAllManufacturers();
        }

        private void update()
        {
            categories = new List<Category>();
            catalogueTreeView.Nodes.Clear();
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
                manufacturers.Add(SQLiteReaderHelper.CreateObject<Manufacturer>(reader,
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
                Category category = SQLiteReaderHelper.CreateObject<Category>(reader, "Id", "Name", "Desc");
                category.Products = new List<Product>();
                // Создание корневого узла
                TreeNode rootNode = new TreeNode(category.Name);
                // Добавление узлов в корневой узел
                foreach (Product product in products)
                {
                    if (category.Id == product.CategoryId)
                    {
                        category.Products.Add(product);
                        rootNode.Nodes.Add(new TreeNode(product.Name));
                    }
                }
                categories.Add(category);

                // Добавление корневого узла в элемент TreeView
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
                products.Add(SQLiteReaderHelper.CreateObject<Product>(reader,
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
            Random rnd = new Random();
            workers = new List<Worker>();
            clients = new List<Client>();
            workers = readAllWorkers();
            clients = readAllClients();

            string query = @"INSERT INTO 'order'
            (OrderDate, DeliveryDate, Status, ClientId, WorkerId)
            VALUES (@OrderDate, @DeliveryDate, @Status, @ClientId, @WorkerId);";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query, DateTime.Now.ToShortDateString(),
                DateTime.Now.AddDays(7).ToShortDateString(), "0",
                mainClient.Id, workers[rnd.Next(0, workers.Count)].Id);
            orders.Clear();
            orders = readAllOrders();
            query = @"INSERT INTO 'order_list'
            (OrderId, ProductId, Count)
            VALUES (@OrderId, @ProductId, @Count);";
            SQLiteReaderHelper.Request(query, orders[orders.Count - 1].Id, selectedProduct.Id, 1);
            MessageBox.Show("Продукт замовлено!");
        }

        private List<Order> readAllOrders()
        {
            string query = @"SELECT * FROM 'order'";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query);
            while (reader.Read()) // построчно считываем данные
            {
                orders.Add(SQLiteReaderHelper.CreateObject<Order>(reader,
                                                "Id",
                                                "OrderDate",
                                                "DeliveryDate",
                                                "Status",
                                                "ClientId",
                                                "WorkerId"));
            }
            return orders;
        }

        private List<Client> readAllClients()
        {
            string query = @"SELECT * FROM client";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query);
            while (reader.Read()) // построчно считываем данные
            {
                clients.Add(SQLiteReaderHelper.CreateObject<Client>(reader,
                                                "Id",
                                                "Name",
                                                "Surname",
                                                "Login",
                                                "Password",
                                                "Email",
                                                "Adress",
                                                "Phone"));
            }
            return clients;
        }

        private List<Worker> readAllWorkers()
        {
            string query = @"SELECT * FROM worker";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query);
            while (reader.Read()) // построчно считываем данные
            {
                workers.Add(SQLiteReaderHelper.CreateObject<Worker>(reader,
                                                "Id",
                                                "Name",
                                                "Surname",
                                                "Adress",
                                                "Phone"));
            }
            return workers;
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
            AddProductForm addProductForm = new AddProductForm(manufacturers, categories);
            addProductForm.ShowDialog();
            update();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            orders.Clear();
            orders = readAllOrders();
            OrdersForm ordersForm = new OrdersForm(orders, products, mainClient);
            ordersForm.Show();
        }
    }

}
