using GloceryShopDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//things to do: remove refresh button; add product button, after saving giving kasova belejka, make it look prettier, comment

namespace GloceryShopDemo
{
    public partial class ShopForm : Form
    {
        Shopping shopping = new Shopping();

        public BindingSource bindingSourceForShopping = new BindingSource();

        public BindingSource bindingSourceForMenu = new BindingSource();

        decimal CashBox = 0.0m;

        public ShopForm()
        {
            InitializeComponent();

            UpdateUI();

            SetDataBindings();

            InitializeMenuGridColumns();

            SetDataSourceMenu();

            InitializeShoppingCardGridColumns();

            SetDataSourceShopping();
        }

        #region Methods

        private void InitializeShoppingCardGridColumns()
        {
            DataGridViewColumn col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Name:";
            col.DataPropertyName = "Name";
            col.ReadOnly = true;
            gvShopping.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Price:";
            col.DataPropertyName = "Price";
            col.ReadOnly = true;
            gvShopping.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Amount:";
            col.DataPropertyName = "Qty";
            col.ReadOnly = true;
            gvShopping.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Sum of the row:";
            col.DataPropertyName = "Sum";
            col.ReadOnly = true;
            gvShopping.Columns.Add(col);
        }

        private void UpdateUI()
        {
            gvMenu.AutoGenerateColumns = false;
            gvShopping.AutoGenerateColumns = false;
        }

        private void SetDataSourceMenu()
        {
            bindingSourceForMenu.DataSource = Product.GetProducts();
            gvMenu.DataSource = bindingSourceForMenu;
        }

        private void SetDataSourceShopping()
        {
            bindingSourceForShopping.DataSource = shopping.Products;

            gvShopping.DataSource = bindingSourceForShopping;
        }

        private void InitializeMenuGridColumns()
        {
            DataGridViewColumn col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Name:";
            col.DataPropertyName = "Name";
            col.ReadOnly = true;
            gvMenu.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Price:";
            col.DataPropertyName = "Price";
            col.ReadOnly = true;
            gvMenu.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Amount:";
            col.DataPropertyName = "Qty";
            col.ReadOnly = false;
            gvMenu.Columns.Add(col);

        }

        private void ClearShopping()
        {
            shopping.Products.Clear();
            tbShoppingCardSum.Text = "";
            bindingSourceForShopping.ResetBindings(false);
        }

        private void SetDataBindings()
        {
            ClearDataBindings(this);
            
            tbShoppingCardSum.Text = string.Format("{0:c}",
                shopping.SumOfAllProducts);
            tbCashBox.Text = string.Format("{0:C}", CashBox);
        }

        private void ClearDataBindings(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                ctrl.DataBindings.Clear();

                ClearDataBindings(ctrl);
            }
        }

        private void AddProductToShopping(Product product)
        {
            Product productToAdd = product.Clone();

            shopping.Products.Add(productToAdd);

            bindingSourceForShopping.ResetBindings(false);

            product.Qty = 0;

            bindingSourceForMenu.ResetBindings(false);
        }
        #endregion

        #region Events

        private void gvMenu_DoubleClick(object sender, EventArgs e)
        {
            DataGridView view = sender as DataGridView;

            Product product = (Product)view.CurrentRow.DataBoundItem;

            if (product.Qty == 0)
            {
                MessageBox.Show("Please enter the amount");
            }
            else
            {
                AddProductToShopping(product);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearShopping();
        }

        private void btnRefreshShopping_Click(object sender, EventArgs e)
        {
            tbShoppingCardSum.Text = shopping.SumOfShopping;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            CashBox += shopping.SumOfAllProducts;

            SetDataBindings();

            ClearShopping();
        }

        #endregion

    }
}
