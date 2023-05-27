using Coffee_Restaurent_Manager.Forms.ProductsUC;
using Coffee_Restaurent_Manager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Restaurent_Manager.Forms.SubForms
{
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }
        private List<ProductView> productList = new List<ProductView>();

        private void LoadProductItems()
        {
            using(SqlService sqlService = new SqlService())
            {
                string query = $@"SELECT * FROM Products";
                DataTable products = sqlService.GetDataQuery(query);
                foreach (DataRow row in products.Rows)
                {
                    ProductView product = new ProductView();
                    product.Id = row["Id"].ToString();
                    product.Title = row["Name"].ToString();
                    if (File.Exists(row["Image"].ToString()))
                    {
                        product.Image = Image.FromFile(row["Image"].ToString());
                    }
                    product.Price = decimal.Parse( row["Price"].ToString());
                    productList.Add(product);
                }
            }
        }

        private void DisplayProducts(List<ProductView> productList)
        {
            foreach (ProductView product in productList)
            {
                this.flowLayoutPanel1.Controls.Add(product);
            }
            
        }
        //Create Order
        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            LoadProductItems();
            DisplayProducts(productList);
        }
    }
}
