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
    public partial class StockListForm : Form
    {
        public StockListForm()
        {
            InitializeComponent();
        }
        BLLStock bls = new BLLStock();
        private void StockListForm_Load(object sender, EventArgs e)
        {
            List<StockDetails> lstst = bls.GetAllStock();
            DataGridView1.DataSource = lstst;
        }
       public int stockid = 0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            stockid = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString());
           
            this.Hide();
            var stock = bls.GetAllStock().Where(s => s.StockID == stockid).FirstOrDefault();
            StockEntryForm frm = new StockEntryForm();
            frm.Show();
            frm.txtStockID.Text = stockid.ToString();
            frm.txtStockNo.Text = stock.StockNo;
            frm.dateTimePicker1.Text = stock.Date.ToLongDateString();
            frm.cboProductName.SelectedValue = stock.ProductID;
            frm.cboSupplierName.SelectedValue = stock.SupplierID;
            frm.txtQuantity.Text = stock.Quantity.ToString();
            frm.txtQuantityInitial.Text = stock.Quantity.ToString();
            frm.btnAddNewStock.Enabled = false;
            frm.btnDeleteStock.Enabled = true;
            frm.btnUpdateStock.Enabled = true;          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            List<StockDetails> lstsd = bls.GetAllStock().Where(s => s.ProductName.StartsWith(txtSearch.text)).ToList();
            DataGridView1.DataSource = lstsd;
           
        }
    }
}
