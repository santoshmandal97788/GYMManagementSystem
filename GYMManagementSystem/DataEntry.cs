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
    public partial class DataEntry : Form
    {
        public DataEntry()
        {
            InitializeComponent();
        }
        CategoryForm cfrm = new CategoryForm();
        SubCategoryForm scfrm = new SubCategoryForm();
        ProductEntryForm pefrm = new ProductEntryForm();
        MembershipTypeEntryForm mtefrm = new MembershipTypeEntryForm();
        private void btnCategory_Click(object sender, EventArgs e)
        {
            cfrm.Show();
            this.Hide();
        }

        private void btnSubCategory_Click(object sender, EventArgs e)
        {
            scfrm.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            pefrm.Show();
            this.Hide();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            mtefrm.Show();
            this.Hide();
        }
    }
}
