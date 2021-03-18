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
    public partial class MainDashboardForm : Form
    {
        public MainDashboardForm()
        {
            InitializeComponent();
        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {
            //var button = new Bunifu.Framework.UI.BunifuTileButton();

            //this.Controls.Add(button);

        }

        private void blblDataEntry_MouseHover(object sender, EventArgs e)
        {
            blblDataEntry.ForeColor = Color.Red;
            panelDataEntry.BackColor = Color.Red;
           
        }
        private void blblDataEntry_MouseLeave(object sender, EventArgs e)
        {
            blblDataEntry.ForeColor = Color.FromArgb(255, 128, 0);
            panelDataEntry.BackColor = Color.FromArgb(255, 128, 0);
        }
        private void blblUsers_MouseHover(object sender, EventArgs e)
        {
            blblUsers.ForeColor = Color.Red;
            panelUsers.BackColor = Color.Red;
        }

        private void blblUsers_MouseLeave(object sender, EventArgs e)
        {
            blblUsers.ForeColor = Color.FromArgb(255, 128, 0);
            panelUsers.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblDatabase_MouseHover(object sender, EventArgs e)
        {
            blblDatabase.ForeColor = Color.Red;
            panelDatabase.BackColor = Color.Red;
        }

        private void blblDatabase_MouseLeave(object sender, EventArgs e)
        {
            blblDatabase.ForeColor = Color.FromArgb(255, 128, 0);
            panelDatabase.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblCustomer_MouseHover(object sender, EventArgs e)
        {
            blblCustomer.ForeColor = Color.Red;
            panelCustomer.BackColor = Color.Red;
        }

        private void blblCustomer_MouseLeave(object sender, EventArgs e)
        {
            blblCustomer.ForeColor = Color.FromArgb(255, 128, 0);
            panelCustomer.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblSupplier_MouseHover(object sender, EventArgs e)
        {
            blblSupplier.ForeColor = Color.Red;
            panelSupplier.BackColor = Color.Red;
        }

        private void blblSupplier_MouseLeave(object sender, EventArgs e)
        {
            blblSupplier.ForeColor = Color.FromArgb(255, 128, 0);
            panelSupplier.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblStock_MouseHover(object sender, EventArgs e)
        {
            blblStock.ForeColor = Color.Red;
            panelStock.BackColor = Color.Red;
        }

        private void blblStock_MouseLeave(object sender, EventArgs e)
        {
            blblStock.ForeColor = Color.FromArgb(255, 128, 0);
            panelStock.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblMember_MouseHover(object sender, EventArgs e)
        {
            blblMember.ForeColor = Color.Red;
            panelMember.BackColor = Color.Red;
        }

        private void blblMember_MouseLeave(object sender, EventArgs e)
        {
            blblMember.ForeColor = Color.FromArgb(255, 128, 0);
            panelMember.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblSales_MouseHover(object sender, EventArgs e)
        {
            blblSales.ForeColor = Color.Red;
            panelSales.BackColor = Color.Red;
        }

        private void blblSales_MouseLeave(object sender, EventArgs e)
        {
            blblSales.ForeColor = Color.FromArgb(255, 128, 0);
            panelSales.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblFitnessMeasures_MouseHover(object sender, EventArgs e)
        {
            blblFitnessMeasures.ForeColor = Color.Red;
            panelFitnessMeasure.BackColor = Color.Red;
        }

        private void blblFitnessMeasures_MouseLeave(object sender, EventArgs e)
        {
            blblFitnessMeasures.ForeColor = Color.FromArgb(255, 128, 0);
            panelFitnessMeasure.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblTools_MouseHover(object sender, EventArgs e)
        {
            blblTools.ForeColor = Color.Red;
            panelTools.BackColor = Color.Red;
        }

        private void blblTools_MouseLeave(object sender, EventArgs e)
        {
            blblTools.ForeColor = Color.FromArgb(255, 128, 0);
            panelTools.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblAbout_MouseHover(object sender, EventArgs e)
        {
            blblAbout.ForeColor = Color.Red;
            panelAbout.BackColor = Color.Red;
        }

        private void blblAbout_MouseLeave(object sender, EventArgs e)
        {
            blblAbout.ForeColor = Color.FromArgb(255, 128, 0);
            panelAbout.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblLogout_MouseHover(object sender, EventArgs e)
        {
            blblLogout.ForeColor = Color.Red;
            panelLogout.BackColor = Color.Red;
        }

        private void blblLogout_MouseLeave(object sender, EventArgs e)
        {
            blblLogout.ForeColor = Color.FromArgb(255, 128, 0);
            panelLogout.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void blblDataEntry_Click(object sender, EventArgs e)
        {
            DataEntry frm1 = new DataEntry();
            frm1.Show();

        }

        private void blblDatabase_Click(object sender, EventArgs e)
        {
            UsersDuplicate frm2 = new UsersDuplicate();
            frm2.Show();
        }

        private void blblUsers_Click(object sender, EventArgs e)
        {
            Users ufrm = new Users();
            ufrm.Show();
        }
    }
}
