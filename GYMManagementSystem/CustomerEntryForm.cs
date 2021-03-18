using BLL;
using BO;
using GYMManagementSystem.Properties;
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
    public partial class CustomerEntryForm : Form
    {
        public CustomerEntryForm()
        {
            InitializeComponent();
        }

        BLLCustomer blc = new BLLCustomer();

        private void CustomerEntryForm_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\NoImage.jpg";
            defaultfilename= Application.StartupPath + "\\NoImage.jpg";
            LoadCustomerNo();
            LoadGrid();
            btnRemoveImage.Enabled = false;
            radioButtonMale.Checked = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtCustomerName.Focus();
            
        }
        private void LoadCustomerNo()
        {
            var customer = blc.GetAllCustomer().OrderByDescending(c => c.C_ID).Take(1).FirstOrDefault();
            if (customer != null)
            {
                string customerno = customer.CustomerNo;
                string[] str = customerno.Split('-');
                int maxno = Convert.ToInt32(str[1].ToString()) + 1;
                txtCustomerNo.Text = "CN-" + maxno.ToString();
            }
            else
            {
                txtCustomerNo.Text = "CN-1";
            }
        }
        private void LoadGrid()
        {
            List<CustomerDetails> lstcd = blc.GetAllCustomer();
            DataGridView1.DataSource = lstcd;
        }
        string filename = "";
        string defaultfilename = "";
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please Choose Customer Image";
            ofd.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                filename = ofd.FileName;
                pictureBox1.ImageLocation = ofd.FileName;
                btnRemoveImage.Enabled = true;
                btnBrowseImage.Enabled = false;
            }
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

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\NoImage.jpg";
            btnBrowseImage.Enabled = true;
            btnRemoveImage.Enabled = false;
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {

            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Customer Address", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            if (txtCity.Text == "")
            {
                MessageBox.Show("Please Enter Customer City", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return;
            }
            if (txtContact.Text == "")
            {
                MessageBox.Show("Please Enter Customer ContactNo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CustomerDetails cd = new CustomerDetails();
            cd.CustomerNo = txtCustomerNo.Text;
            cd.C_Name = txtCustomerName.Text;
            cd.Address = txtAddress.Text;
            if (radioButtonMale.Checked)
            {
                cd.Gender = radioButtonMale.Text;
            }
            else if (radioButtonFemale.Checked)
            {
                cd.Gender = radioButtonFemale.Text;
            }
            else
            {
                cd.Gender = radioButtonOther.Text;
            }
            cd.City = txtCity.Text;
            cd.Email = txtEmail.Text;
            cd.ContactNo = txtContact.Text;
            cd.Photo = imgg;
            int i = blc.AddNewCustomer(cd);
            if (i > 0)
            {
                LoadGrid();
                MessageBox.Show("New Customer Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }
        }
        private void Clear()
        {
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            radioButtonMale.Checked = true;
            txtCity.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            pictureBox1.ImageLocation = Application.StartupPath + "\\NoImage.jpg";
            btnBrowseImage.Enabled = true;
            btnRemoveImage.Enabled = false;
            txtCustomerName.Focus();
            
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
        int customerid = 0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerid = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString());
            var customer = blc.GetAllCustomer().Where(c => c.C_ID == customerid).FirstOrDefault();
            txtCustomerNo.Text = customer.CustomerNo;
            txtCustomerName.Text = customer.C_Name;
            txtAddress.Text = customer.Address;
            if (customer.Gender == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else if (customer.Gender == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonOther.Checked = true;
            }
            txtCity.Text = customer.City;
            txtEmail.Text = customer.Email;
            txtContact.Text = customer.ContactNo;
            byte[] Photo = customer.Photo;
            MemoryStream ms = new MemoryStream(Photo);
            pictureBox1.Image = Image.FromStream(ms);
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddNewCustomer.Enabled = false;
            filename = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Customer Address", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            if (txtCity.Text == "")
            {
                MessageBox.Show("Please Enter Customer City", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return;
            }
            if (txtContact.Text == "")
            {
                MessageBox.Show("Please Enter Customer ContactNo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact.Focus();
                return;
            }
            //if (pictureBox1.ImageLocation == defaultfilename)
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
            CustomerDetails cd = new CustomerDetails();
            cd.C_ID = customerid;
            cd.CustomerNo = txtCustomerNo.Text;
            cd.C_Name = txtCustomerName.Text;
            cd.Address = txtAddress.Text;
            if (radioButtonMale.Checked)
            {
                cd.Gender = radioButtonMale.Text;
            }
            else if (radioButtonFemale.Checked)
            {
                cd.Gender = radioButtonFemale.Text;
            }
            else
            {
                cd.Gender = radioButtonOther.Text;
            }
            cd.City = txtCity.Text;
            cd.Email = txtEmail.Text;
            cd.ContactNo = txtContact.Text;
            cd.Photo = imgg;
            int i = blc.UpdateCustomer(cd);
            if (i > 0)
            {
                LoadGrid();
                MessageBox.Show(" Customer updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoadCustomerNo();

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
            if (MessageBox.Show("Are You Sure Want To Delete Customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = blc.DeleteCustomer(customerid);
                if (i > 0)
                {
                    Clear();
                    MessageBox.Show("Customer Deleted Successfully");
                    LoadGrid();
                    LoadCustomerNo();
                    btnAddNewCustomer.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            else
            {
                btnAddNewCustomer.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                Clear();
                LoadCustomerNo();
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            List<CustomerDetails> lstcd = blc.GetAllCustomer().Where(c => c.C_Name.StartsWith(txtSearch.text)).ToList();
            DataGridView1.DataSource = lstcd;
        }
    }
}
