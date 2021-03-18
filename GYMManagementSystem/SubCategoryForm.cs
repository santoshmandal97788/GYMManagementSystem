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
    public partial class SubCategoryForm : Form
    {
        public SubCategoryForm()
        {
            InitializeComponent();
        }
        BLLCategory blc = new BLLCategory();
        BLLSubCategory blsc = new BLLSubCategory();
    
        private void SubCategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadGrid();
            btnUpdateSubCategory.Enabled = false;
            btnDeleteSubCategory.Enabled = false;
            txtSubCategoryName.Focus();
        }

        private void LoadGrid()
        {
            List<SubCategoryDetails> subcatlst = blsc.GetAllSubCategory();
            DataGridView1.Rows.Clear();
            int i = 0;
            foreach (SubCategoryDetails item in subcatlst)
            {
                DataGridView1.Rows.Add();
                DataGridView1.Rows[i].Cells["colSN"].Value = i + 1;
                DataGridView1.Rows[i].Cells["colSubCatId"].Value = item.SubCatId;
                DataGridView1.Rows[i].Cells["colSubCatName"].Value = item.SubCategoryName;
                DataGridView1.Rows[i].Cells["colCategory"].Value = item.CategoryName;
                i++;
            }
        }

        private void LoadCategory()
        {
            List<CategoryDetails> lstcat = blc.GetAllCategory();

            CategoryDetails cat = new CategoryDetails();
            cat.CategoryName = "Choose Category";
            lstcat.Insert(0, cat);

            cboCategoryName.DataSource = lstcat;
            cboCategoryName.DisplayMember = "CategoryName";
            cboCategoryName.ValueMember = "CategoryId";
        }

        private void btnAddNewSubCategory_Click_1(object sender, EventArgs e)
        {
            if (txtSubCategoryName.Text == "")
            {
                MessageBox.Show("Please Enter Sub-Category Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCategoryName.Focus();
                return;
            }
            if (cboCategoryName.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Category", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoryName.Focus();
                return;
            }

            SubCategoryDetails scd = new SubCategoryDetails();
            scd.SubCategoryName = txtSubCategoryName.Text;
            scd.CategoryId = Convert.ToInt32(cboCategoryName.SelectedValue.ToString());
          

            bool isexists = blsc.CheckSubCategory(txtSubCategoryName.Text);
            if (isexists)
            {
                MessageBox.Show("Sub-Category Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubCategoryName.Text = "";
                txtSubCategoryName.Focus();
            }
            else
            {
                int i = blsc.AddNewSubCategory(scd);
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show("New Sub-Category Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSubCategoryName.Text = "";
                    txtSubCategoryName.Focus();
                    cboCategoryName.SelectedIndex = 0;
                }
            }
        }
        int subcategoryid = 0;
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            subcategoryid = Convert.ToInt32(DataGridView1.CurrentRow.Cells["colSubCatId"].Value.ToString());
            SubCategoryDetails scd = blsc.GetAllSubCategory().Where(sc => sc.SubCatId == subcategoryid).FirstOrDefault();
            txtSubCategoryName.Text = scd.SubCategoryName;
            cboCategoryName.SelectedValue = scd.CategoryId;
            btnAddNewSubCategory.Enabled = false;
            btnUpdateSubCategory.Enabled = true;
            btnDeleteSubCategory.Enabled = true;
        }

        private void btnUpdateSubCategory_Click(object sender, EventArgs e)
        {
            if (txtSubCategoryName.Text == "")
            {
                MessageBox.Show("Please Enter Sub-Category Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubCategoryName.Focus();
                return;
            }
            if (cboCategoryName.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Category", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoryName.Focus();
                return;
            }

            SubCategoryDetails scd = new SubCategoryDetails();
            scd.SubCategoryName = txtSubCategoryName.Text;
            scd.CategoryId = Convert.ToInt32(cboCategoryName.SelectedValue.ToString());
            scd.SubCatId = subcategoryid;

            bool isexists = blsc.CheckSubCategory(txtSubCategoryName.Text);
            if (isexists)
            {
                MessageBox.Show("Sub-Category Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubCategoryName.Text = "";
                txtSubCategoryName.Focus();
            }
            else
            {
                int i = blsc.UpdateSubCategory(scd);
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show("Sub-Category Updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAddNewSubCategory.Enabled = true;
                    btnUpdateSubCategory.Enabled = false;
                    btnDeleteSubCategory.Enabled = false;
                    txtSubCategoryName.Text = "";
                    txtSubCategoryName.Focus();
                    cboCategoryName.SelectedIndex = 0;
                }
            }
        }

        private void btnDeleteSubCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete Sub-Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = blsc.DeleteSubCategory(subcategoryid);
                if (i > 0)
                {
                    txtSubCategoryName.Text = "";
                    MessageBox.Show("Sub-Category Deleted Successfully");
                    LoadGrid();
                    btnAddNewSubCategory.Enabled = true;
                    btnUpdateSubCategory.Enabled = false;
                    btnDeleteSubCategory.Enabled = false;
                    txtSubCategoryName.Text = "";
                    txtSubCategoryName.Focus();
                    cboCategoryName.SelectedIndex = 0;
                }
            }
        }

        private void btnCloseSubCategoryForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            List<SubCategoryDetails> subcatlst = blsc.GetAllSubCategory().Where(sc => sc.SubCategoryName.StartsWith(txtSearch.text)).ToList();
            List<CategoryDetails> lstcat = blc.GetAllCategory().Where(c => c.CategoryName.StartsWith(txtSearch.text)).ToList();
            DataGridView1.DataSource = lstcat;
            DataGridView1.DataSource = subcatlst;

        }

        
    }
}
