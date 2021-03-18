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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        BLLRegistration blr = new BLLRegistration();
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.text == "")
            {
                MessageBox.Show("Please Enter User Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.text == "")
            {
                MessageBox.Show("Please Enter Password ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            var rd = blr.CheckUserLogin(txtUsername.text, txtPassword.text);

            if (txtUsername.text == rd.UserName)
            {
                if (txtPassword.text == rd.Password)
                {
                    MainDashboardForm mdf = new MainDashboardForm();
                    mdf.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Error Login");
            }
           


















        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
