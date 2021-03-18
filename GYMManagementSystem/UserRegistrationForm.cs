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
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }
        BLLRegistration blr = new BLLRegistration();
 
        private void btnRegistar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Please Enter User Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return;
                }
                if (cboUserType.SelectedIndex==0)
                {
                    MessageBox.Show("Please Choose User Type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboUserType.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
                if (txtFullName.Text == "")
                {
                    MessageBox.Show("Please Enter FullName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFullName.Focus();
                    return;
                }
                if (txtContactNo.Text == "")
                {
                    MessageBox.Show("Please Enter Contact No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContactNo.Focus();
                    return;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
                RegistrationDetails rd = new RegistrationDetails();
                rd.UserName = txtUserName.Text;
                rd.UserType = cboUserType.Text;
                rd.Password = txtPassword.Text;
                rd.FullName = txtFullName.Text;
                rd.ContactNo = txtContactNo.Text;
                rd.Email = txtEmail.Text;
                rd.JoiningDate = DateTime.Now;
                int i = blr.RegisterNewUser(rd);
                if (i > 0)
                {
                    LoadGrid();
                    Clear();
                    MessageBox.Show("New User Registered Successfully", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_Validating_1(object sender, CancelEventArgs e)
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
        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadGrid()
        {
            List<RegistrationDetails> lstuser = blr.GetAllUser();
            DataGridView1.DataSource = lstuser;
        }
        private void Clear()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtContactNo.Text = "";
            txtEmail.Text = "";
            txtUserName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        int userid = 0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userid = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString());
            var user = blr.GetAllUser().Where(u => u.UserId == userid).FirstOrDefault();
            txtUserName.Text = user.UserName;
            cboUserType.Text = user.UserType;
            txtPassword.Text = user.Password;
            txtFullName.Text = user.FullName;
            txtEmail.Text = user.Email;
            txtContactNo.Text = user.ContactNo;
            btnRegistar.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Please Enter User Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return;
                }
                if (cboUserType.Text == "")
                {
                    MessageBox.Show("Please Choose User Type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboUserType.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
                if (txtFullName.Text == "")
                {
                    MessageBox.Show("Please Enter FullName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFullName.Focus();
                    return;
                }
                if (txtContactNo.Text == "")
                {
                    MessageBox.Show("Please Enter Contact No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContactNo.Focus();
                    return;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
                RegistrationDetails rd = new RegistrationDetails();
                rd.UserName = txtUserName.Text;
                rd.UserType = cboUserType.Text;
                rd.Password = txtPassword.Text;
                rd.FullName = txtFullName.Text;
                rd.ContactNo = txtContactNo.Text;
                rd.Email = txtEmail.Text;
                rd.JoiningDate = DateTime.Now;
                int i = blr.RegisterNewUser(rd);
                if (i > 0)
                {
                    LoadGrid();
                    Clear();
                    btnRegistar.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    cboUserType.Text = "Choose User Type";
                    MessageBox.Show("User Updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            if(MessageBox.Show("Are You Sure Want To Delete Registered User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = blr.DeleteRegisteredUser(userid);
                if (i > 0)
                {
                    LoadGrid();
                    Clear();
                    btnRegistar.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    cboUserType.Text = "Choose User Type";
                    MessageBox.Show("User Deleted Successfully");
                   
                }
            }
           
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            List<RegistrationDetails> lstuser = blr.GetAllUser().Where(a => a.UserName.StartsWith(txtSearch.text)).ToList();
            List<RegistrationDetails> lstusers = blr.GetAllUser().Where(a => a.UserType.StartsWith(txtSearch.text)).ToList();

            DataGridView1.DataSource = lstuser;
            DataGridView1.DataSource = lstusers;
        }
    }
}
