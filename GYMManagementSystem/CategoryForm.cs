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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        BLLCategory blc = new BLLCategory();

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please Enter Category Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            CategoryDetails cd = new CategoryDetails();
            cd.CategoryName = txtCategoryName.Text;

            bool isexists = blc.CheckCategory(txtCategoryName.Text);
            if (isexists)
            {
                MessageBox.Show("Category Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Text = "";
                txtCategoryName.Focus();
            }
            else
            {
                int i = blc.AddNewCategory(cd);
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show("New Category Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    txtCategoryName.Text = "";
                    txtCategoryName.Focus();
                }
            }
        }
        private void LoadGrid()
        {
            List<CategoryDetails> lstcat = blc.GetAllCategory();
            DataGridView1.DataSource = lstcat;
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            btnAddNewCategory.Enabled = true;
            btnUpdateCategory.Enabled = false;
            btnDeleteCategory.Enabled = false;
            txtCategoryName.Focus();
        }
        int categoryid = 0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoryid = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString());
            var category = blc.GetAllCategory().Where(c => c.CategoryId == categoryid).FirstOrDefault();
            txtCategoryName.Text = category.CategoryName;
            btnAddNewCategory.Enabled = false;
            btnUpdateCategory.Enabled = true;
            btnDeleteCategory.Enabled = true;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please Enter Category Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            CategoryDetails cd = new CategoryDetails();
            cd.CategoryName = txtCategoryName.Text;
            cd.CategoryId = categoryid;

            bool isexists = blc.CheckCategory(txtCategoryName.Text);
            if (isexists)
            {
                MessageBox.Show("Category Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Text = "";
                txtCategoryName.Focus();
            }
            else
            {
                int i = blc.UpdateCategory(cd);
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show("Category Updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAddNewCategory.Enabled = true;
                    btnUpdateCategory.Enabled = false;
                    btnDeleteCategory.Enabled = false;
                    txtCategoryName.Text = "";
                    txtCategoryName.Focus();
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = blc.DeleteCategory(categoryid);
                if (i > 0)
                {
                    txtCategoryName.Text = "";
                    MessageBox.Show("Category Deleted Successfully");
                    LoadGrid();
                    btnAddNewCategory.Enabled = true;
                    btnUpdateCategory.Enabled = false;
                    btnDeleteCategory.Enabled = false;
                }
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            List<CategoryDetails> lstcat = blc.GetAllCategory().Where(c => c.CategoryName.StartsWith(txtSearch.text)).ToList();
            DataGridView1.DataSource = lstcat;
        }

        private void btnCloseCategoryForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuGradientPanelCategoryInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCategoryName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LabelCategoryName_Click(object sender, EventArgs e)
        {

        }

        private void labelNewCategory_Click(object sender, EventArgs e)
        {

        }

        private void LabelUserList_Click(object sender, EventArgs e)
        {

        }

        private void panelHeading_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabelHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
