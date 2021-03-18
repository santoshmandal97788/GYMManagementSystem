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
    public partial class MembershipTypeEntryForm : Form
    {
        public MembershipTypeEntryForm()
        {
            InitializeComponent();
        }
        BLLMembershipType blmt = new BLLMembershipType();
        private void btnAddNewMembershipType_Click_1(object sender, EventArgs e)
        {
            if (txtMembershipType.Text == "")
            {
                MessageBox.Show("Please Enter MembershipType Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMembershipType.Focus();
                return;
            }
            if (txtChargePerMonth.Text == "")
            {
                MessageBox.Show("Please Enter Charges per Month", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChargePerMonth.Focus();
                return;
            }
            if (txtServicetax.Text == "")
            {
                MessageBox.Show("Please Enter Service TAX %", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServicetax.Focus();
                return;
            }
            if (txtVAT.Text == "")
            {
                MessageBox.Show("Please Enter VAT %", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVAT.Focus();
                return;
            }
            MembershipTypeDetails mtd = new MembershipTypeDetails();
            mtd.MembershipType = txtMembershipType.Text;
            mtd.ChargesPerMonth = Convert.ToDecimal(txtChargePerMonth.Text);
            mtd.ServiceTAX = Convert.ToDecimal(txtServicetax.Text);
            mtd.VAT = Convert.ToDecimal(txtVAT.Text);

            bool isexists = blmt.CheckMembershipType(txtMembershipType.Text);
            if (isexists)
            {
                MessageBox.Show("Membership Type Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMembershipType.Text = "";
                txtMembershipType.Focus();
            }
            else
            {
                int i = blmt.AddNewMembershipType(mtd);
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show("New Membership Type Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }

        private void Clear()
        {
            txtMembershipType.Text = "";
            txtChargePerMonth.Text = "";
            txtServicetax.Text = "";
            txtVAT.Text = "";
            txtMembershipType.Focus();
            btnAddNewMembershipType.Enabled = true;
            btnUpdateMembershipType.Enabled = false;
            btnDeleteMembershipType.Enabled = false;
        }

        private void LoadGrid()
        {
            List<MembershipTypeDetails> lstmt = blmt.GetAllMembershipType();
            DataGridView1.DataSource = lstmt;
        }

        private void MembershipTypeEntryForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtChargePerMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtChargePerMonth.Text.Contains("."))
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
        int membershiptypeid=0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            membershiptypeid = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString());
            var membershiptype = blmt.GetAllMembershipType().Where(c => c.MT_ID == membershiptypeid).FirstOrDefault();
            txtMembershipType.Text = membershiptype.MembershipType;
            txtChargePerMonth.Text = membershiptype.ChargesPerMonth.ToString();
            txtServicetax.Text = membershiptype.ServiceTAX.ToString();
            txtVAT.Text = membershiptype.VAT.ToString();
            btnAddNewMembershipType.Enabled = false;
            btnUpdateMembershipType.Enabled = true;
            btnDeleteMembershipType.Enabled = true;
        }

        private void btnUpdateMembershipType_Click(object sender, EventArgs e)
        {
            if (txtMembershipType.Text == "")
            {
                MessageBox.Show("Please Enter MembershipType Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMembershipType.Focus();
                return;
            }
            if (txtChargePerMonth.Text == "")
            {
                MessageBox.Show("Please Enter Charges per Month", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChargePerMonth.Focus();
                return;
            }
            if (txtServicetax.Text == "")
            {
                MessageBox.Show("Please Enter Service TAX %", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServicetax.Focus();
                return;
            }
            if (txtVAT.Text == "")
            {
                MessageBox.Show("Please Enter VAT %", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVAT.Focus();
                return;
            }

            MembershipTypeDetails mtd = new MembershipTypeDetails();
            mtd.MT_ID = membershiptypeid;
            mtd.MembershipType = txtMembershipType.Text;
            mtd.ChargesPerMonth = Convert.ToDecimal(txtChargePerMonth.Text);
            mtd.ServiceTAX = Convert.ToDecimal(txtServicetax.Text);
            mtd.VAT = Convert.ToDecimal(txtVAT.Text);


            bool isexists = blmt.CheckMembershipType(txtMembershipType.Text);
            if (isexists)
            {
                MessageBox.Show("Membership Type Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMembershipType.Text = "";
                txtMembershipType.Focus();
            }
            else
            {
                int i = blmt.UpdateMembershipType(mtd);
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show("Membership Type Updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }

        private void btnDeleteMembershipType_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete Membership Type?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = blmt.DeleteMembershipType(membershiptypeid);
                if (i > 0)
                {
                    Clear();
                    MessageBox.Show("Membership Type Deleted Successfully");
                    LoadGrid();
                    
                }
            }
            else
            {
                Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            List<MembershipTypeDetails> lstmt = blmt.GetAllMembershipType().Where(m => m.MembershipType.StartsWith(txtSearch.text)).ToList();
            DataGridView1.DataSource = lstmt;
        }
    }
}
