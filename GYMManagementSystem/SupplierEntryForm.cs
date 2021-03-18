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
    public partial class SupplierEntryForm : Form
    {
        public SupplierEntryForm()
        {
            InitializeComponent();
        }
        BLLSupplier bls = new BLLSupplier();
        private void SupplierEntryForm_Load(object sender, EventArgs e)
        {
            pictureBoxSupplierImage.ImageLocation = Application.StartupPath + "\\NoImage.jpg";
            defaultfilename = Application.StartupPath + "\\NoImage.jpg";
            LoadSupplierNo();
            LoadGrid();
            btnRemoveImage.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtSupplierName.Focus();
        }
        private void LoadSupplierNo()
        {
            var supplier = bls.GetAllSupplier().OrderByDescending(s => s.S_ID).Take(1).FirstOrDefault();
            if (supplier != null)
            {
                string supplierno = supplier.SupplierNo ;
                string[] str = supplierno.Split('-');
                int maxno = Convert.ToInt32(str[1].ToString()) + 1;
                txtSupplierID.Text = "SN-" + maxno.ToString();
            }
            else
            {
                txtSupplierID.Text = "SN-1";
            }
        }
        private void LoadGrid()
        {
            List<SupplierDetails> lstsd = bls.GetAllSupplier();
            DataGridView1.DataSource = lstsd;
        }
        string filename = "";
        string defaultfilename = "";
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please Choose Supplier Image";
            ofd.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                filename = ofd.FileName;
                pictureBoxSupplierImage.ImageLocation = ofd.FileName;
                btnRemoveImage.Enabled = true;
                btnBrowseImage.Enabled = false;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pictureBoxSupplierImage.ImageLocation = Application.StartupPath + "\\NoImage.jpg";
            btnBrowseImage.Enabled = true;
            btnRemoveImage.Enabled = false;
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "")
            {
                MessageBox.Show("Please Enter Supplier Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierName.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Supplier Address", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            if (txtCity.Text == "")
            {
                MessageBox.Show("Please Enter Supplier City", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Supplier Email", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtContact.Text == "")
            {
                MessageBox.Show("Please Enter Supplier ContactNo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact.Focus();
                return;
            }
            //if (pictureBox1.Image == null)
            //{
            //    MessageBox.Show("Please Choose Customer Image", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    pictureBox1.Focus();
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
            SupplierDetails sd = new SupplierDetails();
            sd.SupplierNo = txtSupplierID.Text;
            sd.S_Name = txtSupplierName.Text;
            sd.Address = txtAddress.Text;
            sd.City = txtCity.Text;
            sd.Email = txtEmail.Text;
            sd.ContactNo = txtContact.Text;
            sd.Photo = imgg;
            int i = bls.AddNewSupplier(sd);
            if (i > 0)
            {
                LoadGrid();
                MessageBox.Show("New Supplier Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }
        }
        private void Clear()
        {
            txtSupplierName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            pictureBoxSupplierImage.ImageLocation = Application.StartupPath + "\\NoImage.jpg";
            btnBrowseImage.Enabled = true;
            btnRemoveImage.Enabled = false;
            txtSupplierName.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        int supplierid = 0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            supplierid = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString());
            var supplier = bls.GetAllSupplier().Where(s => s.S_ID == supplierid).FirstOrDefault();
            txtSupplierID.Text = supplier.SupplierNo;
            txtSupplierName.Text = supplier.S_Name;
            txtAddress.Text = supplier.Address;
            txtCity.Text = supplier.City;
            txtEmail.Text = supplier.Email;
            txtContact.Text = supplier.ContactNo;
            byte[] Photo = supplier.Photo;
            MemoryStream ms = new MemoryStream(Photo);
            pictureBoxSupplierImage.Image = Image.FromStream(ms);
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddNewSupplier.Enabled = false;
            filename = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "")
            {
                MessageBox.Show("Please Enter Supplier Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierName.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Supplier Address", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            if (txtCity.Text == "")
            {
                MessageBox.Show("Please Enter Supplier City", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Supplier Email", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtContact.Text == "")
            {
                MessageBox.Show("Please Enter Supplier ContactNo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact.Focus();
                return;
            }
            if (pictureBoxSupplierImage.ImageLocation == defaultfilename)
            {
                MessageBox.Show("Please Choose Supplier Image", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBoxSupplierImage.Focus();
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
            SupplierDetails sd = new SupplierDetails();
            sd.S_ID = supplierid;
            sd.SupplierNo = txtSupplierID.Text;
            sd.S_Name = txtSupplierName.Text;
            sd.Address = txtAddress.Text;
            sd.City = txtCity.Text;
            sd.Email = txtEmail.Text;
            sd.ContactNo = txtContact.Text;
            sd.Photo = imgg;
            int i = bls.UpdateSupplier(sd);
            if (i > 0)
            {
                LoadGrid();
                MessageBox.Show(" Supplier updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoadSupplierNo();

            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Invalid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    e.Cancel = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete Supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = bls.DeleteSupplier(supplierid);
                if (i > 0)
                {
                    Clear();
                    MessageBox.Show("Supplier Deleted Successfully");
                    LoadGrid();
                    LoadSupplierNo();
                    btnAddNewSupplier.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            else
            {
                btnAddNewSupplier.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                Clear();
                LoadSupplierNo();
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            List<SupplierDetails> lstsd = bls.GetAllSupplier().Where(s => s.S_Name.StartsWith(txtSearch.text)).ToList();
            DataGridView1.DataSource = lstsd;
        }
        //public byte[] ConvertFiltoByte(string filename)
        //{
        //    byte[] Photo = null;
        //    FileInfo fInfo = new FileInfo(filename);
        //    long numBytes = fInfo.Length;
        //    FileStream fstream = new FileStream(filename, FileMode.Open, FileAccess.Read);
        //    BinaryReader brdr = new BinaryReader(fstream);
        //    Photo = brdr.ReadBytes((int)numBytes);

        //    return Photo;
        //}
    }
}
