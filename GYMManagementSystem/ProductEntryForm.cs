using BLL;
using BO;
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

namespace GYMManagementSystem
{
    public partial class ProductEntryForm : Form
    {
        public ProductEntryForm()
        {
            InitializeComponent();
        }
        BLLProduct blp = new BLLProduct();
        BLLCategory blc = new BLLCategory();
        BLLSubCategory blsc = new BLLSubCategory();
        private void ProductEntryForm_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\images.png";
            defaultfilename = Application.StartupPath + "\\images.png";
            LoadProductNo();
            LoadGrid();
            LoadCategory();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            
        }
        private void LoadProductNo()
        {
            var product = blp.GetAllProducts().OrderByDescending(p => p.PID).Take(1).FirstOrDefault();
            if (product != null)
            {
                string productno = product.ProductNo;
                string[] str = productno.Split('-');
                int maxno = Convert.ToInt32(str[1].ToString()) + 1;
                txtProductID.Text = "PN-" + maxno.ToString();
            }
            else
            {
                txtProductID.Text = "PN-1";
            }
        }
        private void LoadGrid()
        {
            List<ProductDetails> lstpro = blp.GetAllProducts();
            DataGridView1.DataSource = lstpro;
        }
        private void LoadCategory()
        {
            List<CategoryDetails> lstcat = blc.GetAllCategory();

            CategoryDetails cat = new CategoryDetails();
            cat.CategoryName = "Choose Category";
            lstcat.Insert(0, cat);

            cboCategory.DataSource = lstcat;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";
        }
        string filename = "";
        string defaultfilename = "";
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please Choose Product Image";
            ofd.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex != 0)
            {

                int categoryid = Convert.ToInt32(cboCategory.SelectedValue.ToString());
                List<SubCategoryDetails> lstsubcat = blsc.GetAllSubCategory().Where(s => s.CategoryId == categoryid).ToList();
                if (lstsubcat.Count > 0)
                {
                    cboSubCategory.Enabled = true;
                    SubCategoryDetails scd = new SubCategoryDetails();
                    scd.SubCategoryName = "Choose Sub-Category";
                    lstsubcat.Insert(0, scd);
                    cboSubCategory.DataSource = lstsubcat;
                    cboSubCategory.DisplayMember = "SubCategoryName";
                    cboSubCategory.ValueMember = "SubCatId";
                }
                else
                {
                    cboSubCategory.Enabled = false;
                }
            }
            else
            {
                cboSubCategory.Enabled = false;
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please Enter Product Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            if (cboCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Category", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCategory.Focus();
                return;
            }
            if (cboSubCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Sub-category", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSubCategory.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please Enter Product Price", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (txtServicetax.Text == "")
            {
                MessageBox.Show("Please Enter Service TAX %", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServicetax.Focus();
                return;
            }
            if (txtVAT.Text == "")
            {
                MessageBox.Show("Please Enter VAT %", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVAT.Focus();
                return;
            }
            if (txtDiscount.Text == "")
            {
                MessageBox.Show("Please Enter Discount %", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscount.Focus();
                return;
            }
            if (txtFeatures.Text == "")
            {
                MessageBox.Show("Please Write Product Features", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFeatures.Focus();
                return;
            }
            //if (pictureBox1.Image == null)
            //{
            //    MessageBox.Show("Please Choose Product Image", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    btnBrowseImage.Focus();
            //    return;
            //}
            byte[] imgg = null;
            if (filename == "")
            {
                FileStream stream = new FileStream(defaultfilename, FileMode.Open, FileAccess.Read);
                BinaryReader brrdr = new BinaryReader(stream);
                imgg = brrdr.ReadBytes((int)stream.Length);

            }
            else
            {
                FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader brrdr = new BinaryReader(stream);
                imgg = brrdr.ReadBytes((int)stream.Length);
            }
            ProductDetails pd = new ProductDetails();
            pd.ProductNo = txtProductID.Text;
            pd.ProductName = txtProductName.Text;
            pd.Category = cboCategory.Text;
            pd.SubCategoryID = Convert.ToInt32(cboSubCategory.SelectedIndex);
            pd.Features = txtFeatures.Text;
            pd.VAT = Convert.ToDecimal(txtVAT.Text);
            pd.ServiceTAX = Convert.ToDecimal(txtServicetax.Text);
            pd.Discount = Convert.ToDecimal(txtDiscount.Text);
            pd.Price = Convert.ToDecimal(txtPrice.Text);
            pd.Photo = imgg;

            bool isexists = blp.CheckProduct(txtProductName.Text);
            if (isexists)
            {
                MessageBox.Show("Product Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Text = "";
                txtProductName.Focus();
            }
            else
            {
                int i = blp.AddNewProduct(pd);
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show("New Product Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                }
            }
        }
        private void Clear()
        {
            txtProductName.Text = "";
            cboCategory.SelectedIndex = 0;
            cboSubCategory.SelectedIndex = 0;
            txtPrice.Text = "";
            txtVAT.Text = "";
            txtServicetax.Text = "";
            txtDiscount.Text = "";
            txtFeatures.Text = "";
            pictureBox1.ImageLocation = Application.StartupPath + "\\images.png";
        }
        int productid = 0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productid = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString());
            var product = blp.GetAllProducts().Where(p => p.PID == productid).FirstOrDefault();
            txtProductID.Text = product.ProductNo;
            txtProductName.Text = product.ProductName;
            cboCategory.Text = product.Category;
            cboSubCategory.Text = product.SubCategoryName;
            txtPrice.Text = product.Price.ToString();
            txtServicetax.Text = product.ServiceTAX.ToString();
            txtVAT.Text = product.VAT.ToString();
            txtDiscount.Text = product.Discount.ToString();
            txtFeatures.Text = product.Features;
            byte[] Photo = product.Photo;
            MemoryStream ms = new MemoryStream(Photo);
            pictureBox1.Image = Image.FromStream(ms);
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddNewProduct.Enabled = false;
            filename = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please Enter Product Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            if (cboCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Category", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCategory.Focus();
                return;
            }
            if (cboSubCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Sub-category", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSubCategory.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please Enter Product Price", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (txtServicetax.Text == "")
            {
                MessageBox.Show("Please Enter Service TAX %", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServicetax.Focus();
                return;
            }
            if (txtVAT.Text == "")
            {
                MessageBox.Show("Please Enter VAT %", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVAT.Focus();
                return;
            }
            if (txtDiscount.Text == "")
            {
                MessageBox.Show("Please Enter Discount %", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscount.Focus();
                return;
            }
            if (txtFeatures.Text == "")
            {
                MessageBox.Show("Please Write Product Features", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFeatures.Focus();
                return;
            }
            if (pictureBox1.ImageLocation == defaultfilename)
            {
                MessageBox.Show("Please Choose Product Image", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBrowseImage.Focus();
                return;
            }
            byte[] imgg = null;
            if (filename == "")
            {
                FileStream stream = new FileStream(defaultfilename, FileMode.Open, FileAccess.Read);
                BinaryReader brrdr = new BinaryReader(stream);
                imgg = brrdr.ReadBytes((int)stream.Length);

            }
            else
            {
                FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader brrdr = new BinaryReader(stream);
                imgg = brrdr.ReadBytes((int)stream.Length);
            }
            ProductDetails pd = new ProductDetails();
            pd.PID = productid;
            pd.ProductNo = txtProductID.Text;
            pd.ProductName = txtProductName.Text;
            pd.Category = cboCategory.Text;
            pd.SubCategoryID = Convert.ToInt32(cboSubCategory.SelectedIndex);
            pd.Features = txtFeatures.Text;
            pd.VAT = Convert.ToDecimal(txtVAT.Text);
            pd.ServiceTAX = Convert.ToDecimal(txtServicetax.Text);
            pd.Discount = Convert.ToDecimal(txtDiscount.Text);
            pd.Price = Convert.ToDecimal(txtPrice.Text);
            pd.Photo = imgg;

            bool isexists = blp.CheckProduct(txtProductName.Text);
            if (isexists)
            {
                MessageBox.Show("Product Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Text = "";
                txtProductName.Focus();
            }
            else
            {
                int i = blp.UpdateProduct(pd);
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show("Product Updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    LoadProductNo();
                    btnAddNewProduct.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete Product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = blp.DeleteProduct(productid);
                if (i > 0)
                {
                    Clear();
                    MessageBox.Show("Product Deleted Successfully");
                    LoadGrid();
                    LoadProductNo();
                    btnAddNewProduct.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            else
            {
                btnAddNewProduct.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                Clear();
                LoadProductNo();
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            List<ProductDetails> lstpd = blp.GetAllProducts().Where(p => p.ProductName.StartsWith(txtSearch.text)).ToList();
            DataGridView1.DataSource = lstpd;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtPrice.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtServicetax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtServicetax.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtVAT.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtDiscount.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
