using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Restaurent_Manager.Forms.ProductsUC
{
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();
        }

        #region Properties
        private string _Title;
        private decimal _Price;
        private int _Quantity;
        private Image _Image;
        private string _Id;

        [Category("Custom Props")]
        public string Title 
        {
            get { return _Title; }
            set { _Title = value; this.label_Title.Text = value; } 
        }

        [Category("Custom Props")]
        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; this.label_Price.Text = "Price: " +value.ToString() + "đ"; }
        }

        [Category("Custom Props")]
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        [Category("Custom Props")]
        public Image Image
        { 
            get { return _Image; }
            set { _Image = value; this.pictureBox1.Image = value; }
        }
        public string Id
        {
            get { return  this._Id; }
            set { _Id = value; }
        }
        #endregion

        private void AmountValue_ValueChanged(object sender, EventArgs e)
        {
            _Quantity = int.Parse(this.AmountValue.Value.ToString());
        }
    }
}
