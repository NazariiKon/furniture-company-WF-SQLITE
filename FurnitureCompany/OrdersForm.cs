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
    public partial class OrdersForm : Form
    {
        List<OrderList> orderList = new List<OrderList>();
        Order mainOrder;

        public OrdersForm(List<Order> orders, List<Product> products, Client client)
        {
            InitializeComponent();
            orderList = readAllOrderList();

            foreach (Order order in orders)
            {
                if (order.ClientId == client.Id)
                {
                    foreach (OrderList list in orderList)
                    {
                        if (list.OrderId == order.Id)
                        {
                            foreach (Product product in products)
                            {
                                if (list.ProductId == product.Id)
                                {
                                    order.Info = product.Name;
                                    order.Price = product.Price.ToString();
                                }
                            }
                        }
                    }
                    listBoxOrders.Items.Add(order);
                }
            }
            listBoxOrders.ValueMember = "Info";
        }

        private List<OrderList> readAllOrderList()
        {
            string query = @"SELECT * FROM order_list";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query);
            return SQLiteReaderHelper.readObjects(reader, r => SQLiteReaderHelper.CreateObject<OrderList>(r,
                "Id", "OrderId", "ProductId", "Count"));
        }

        private Worker searchWorker()
        {
            string query = @"SELECT * FROM worker WHERE Id = @param;";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query, mainOrder.WorkerId);
            return SQLiteReaderHelper.readObjects(reader, r => SQLiteReaderHelper.CreateObject<Worker>(r,
                "Id", "Name", "Surname", "Adress", "Phone")).FirstOrDefault();
        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {
            WorkerForm worker = new WorkerForm(searchWorker());
            worker.Show();
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainOrder = listBoxOrders.SelectedItem as Order;
            textBoxProduct.Text = mainOrder.Info;
            textBoxPrice.Text = mainOrder.Price;
            textBoxDateOrder.Text = mainOrder.OrderDate.ToString();
            textBoxDateDeliv.Text = mainOrder.DeliveryDate.ToString();
            if (mainOrder.Status == 0)
            {
                textBoxStatus.Text = "Замовлено";
            }
            else
            {
                textBoxStatus.Text = "Доставлено";
            }
        }
    }
}
