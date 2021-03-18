using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMManagementSystem
{
    public partial class StockEntryForm : Form
    {
        public StockEntryForm()
        {
            InitializeComponent();
        }
        BLLStock blst = new BLLStock();
        BLLProduct blp = new BLLProduct();
        BLLSupplier bls = new BLLSupplier();
        BLLTempStock bts = new BLLTempStock();
        private void StockEntryForm_Load(object sender, EventArgs e)
        {
            LoadStockID();
            LoadProductList();
            LoadSupplierList();
            btnUpdateStock.Enabled = false;
            btnDeleteStock.Enabled = false;
        }
        private void LoadStockID()
        {
            var stock = blst.GetAllStock().OrderByDescending(s => s.StockID).Take(1).FirstOrDefault();
            if (stock != null)
            {
                string stockid = stock.StockNo;
                string[] str = stockid.Split('-');
                int maxno = Convert.ToInt32(str[1].ToString()) + 1;
                txtStockNo.Text = "STN-" + maxno.ToString();
            }
            else
            {
                txtStockNo.Text = "STN-1";
            }
        }
        private void LoadProductList()
        {
            List<ProductDetails> lstpro = blp.GetAllProducts();

            ProductDetails pro = new ProductDetails();
            pro.ProductName = "Choose Product";
            lstpro.Insert(0, pro);

            cboProductName.DataSource = lstpro;
            cboProductName.DisplayMember = "ProductName";
            cboProductName.ValueMember = "PID";
        }
        private void LoadSupplierList()
        {
            List<SupplierDetails> lstsupp = bls.GetAllSupplier();

            SupplierDetails supp = new SupplierDetails();
            supp.S_Name = "Choose Supplier";
            lstsupp.Insert(0, supp);

            cboSupplierName.DataSource = lstsupp;
            cboSupplierName.DisplayMember = "S_Name";
            cboSupplierName.ValueMember = "S_ID";
        }

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {

            if (cboProductName.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Product Name!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProductName.Focus();
                return;
            }
            if (cboSupplierName.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Supplier Name!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSupplierName.Focus();
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please Enter Product Quantity!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            

            StockDetails sd = new StockDetails();
            sd.StockNo = txtStockNo.Text;
            sd.ProductID = Convert.ToInt32(cboProductName.SelectedValue);
            sd.SupplierID = Convert.ToInt32(cboSupplierName.SelectedValue);
            sd.Quantity =Convert.ToInt32(txtQuantity.Text);
            sd.Date = dateTimePicker1.MinDate;

            bool isexists = bts.CheckExistingProductStockById(Convert.ToInt32(cboProductName.SelectedValue.ToString()));
            if (isexists)
            {
                
                TempStockDetails tsd = new TempStockDetails();
                tsd.ProductID = Convert.ToInt32(cboProductName.SelectedValue.ToString());

                tsd.Quantity = tsd.Quantity + Convert.ToInt32(txtQuantity.Text);
                int j = bts.UpdateExistingTempStock(tsd);
            }
            else
            {
                TempStockDetails tsd = new TempStockDetails();
                tsd.ProductID = Convert.ToInt32(cboProductName.SelectedValue.ToString());
                tsd.Quantity = Convert.ToInt32(txtQuantity.Text);
                int k = bts.AddNewTempStock(tsd);
            }
            int i = blst.AddNewStock(sd);
            if (i > 0)
            {
                MessageBox.Show("Stock Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoadStockID();
            }
        }
        private void Clear()
        {
            cboProductName.SelectedIndex = 0;
            cboSupplierName.SelectedIndex = 0;
            txtQuantity.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToString();
            txtStockNo.Focus();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            StockListForm frm = new StockListForm();
            frm.Show();
            this.Hide();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (cboProductName.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Product Name!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProductName.Focus();
                return;
            }
            if (cboSupplierName.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Supplier Name!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSupplierName.Focus();
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please Enter Product Quantity!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            //For Updating temp_stock
            TempStockDetails tsd = new TempStockDetails();
            tsd.ProductID = Convert.ToInt32(cboProductName.SelectedValue.ToString());
            tsd.Quantity = ((tsd.Quantity + Convert.ToInt32(txtQuantity.Text))-Convert.ToInt32(txtQuantityInitial.Text));
            int j = bts.UpdateExistingTempStock(tsd);

            //For Updating Stock Record or List
            StockDetails sd = new StockDetails();
            sd.StockID = Convert.ToInt32(txtStockID.Text);
            sd.StockNo = txtStockNo.Text;
            sd.ProductID = Convert.ToInt32(cboProductName.SelectedValue);
            sd.SupplierID = Convert.ToInt32(cboSupplierName.SelectedValue);
            sd.Quantity = Convert.ToInt32(txtQuantity.Text);
            sd.Date = dateTimePicker1.MinDate;
            int i = blst.UpdateStock(sd);
            if (i > 0)
            {
                MessageBox.Show("Stock Updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoadStockID();
                btnAddNewStock.Enabled = true;
                btnUpdateStock.Enabled = false;
                btnDeleteStock.Enabled = false;

            }
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete Stock Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //For Updating temp_stock
                TempStockDetails tsd = new TempStockDetails();
                tsd.ProductID = Convert.ToInt32(cboProductName.SelectedValue.ToString());
                tsd.Quantity = tsd.Quantity - Convert.ToInt32(txtQuantity.Text);
                int j = bts.UpdateExistingTempStock(tsd);
                //For Deleting Stock Record
                int i = blst.DeleteStock(Convert.ToInt32(txtStockID.Text));
                if (i > 0)
                {
                    Clear();
                    MessageBox.Show("Stock Record Deleted Successfully");
                    LoadStockID();
                    btnAddNewStock.Enabled = true;
                    btnUpdateStock.Enabled = false;
                    btnDeleteStock.Enabled = false;
                }
            }
        }
    }
}
