namespace GYMManagementSystem
{
    partial class DataEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEntry));
            this.bunifuElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseTile1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCategory = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipseSubCategory = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSubCategory = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipseProducts = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnProducts = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipseMembership = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnMembership = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipseClose = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipseForm
            // 
            this.bunifuElipseForm.ElipseRadius = 55;
            this.bunifuElipseForm.TargetControl = this;
            // 
            // bunifuElipseTile1
            // 
            this.bunifuElipseTile1.ElipseRadius = 30;
            this.bunifuElipseTile1.TargetControl = this.btnCategory;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCategory.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCategory.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::GYMManagementSystem.Properties.Resources.icons8_categorize_100;
            this.btnCategory.ImagePosition = 20;
            this.btnCategory.ImageZoom = 50;
            this.btnCategory.LabelPosition = 41;
            this.btnCategory.LabelText = "Category";
            this.btnCategory.Location = new System.Drawing.Point(21, 15);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(6);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(128, 129);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // bunifuElipseSubCategory
            // 
            this.bunifuElipseSubCategory.ElipseRadius = 30;
            this.bunifuElipseSubCategory.TargetControl = this.btnSubCategory;
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubCategory.color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubCategory.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSubCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubCategory.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnSubCategory.ForeColor = System.Drawing.Color.White;
            this.btnSubCategory.Image = global::GYMManagementSystem.Properties.Resources.icons8_category_100;
            this.btnSubCategory.ImagePosition = 20;
            this.btnSubCategory.ImageZoom = 50;
            this.btnSubCategory.LabelPosition = 41;
            this.btnSubCategory.LabelText = "SCategory";
            this.btnSubCategory.Location = new System.Drawing.Point(161, 15);
            this.btnSubCategory.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.Size = new System.Drawing.Size(128, 129);
            this.btnSubCategory.TabIndex = 0;
            this.btnSubCategory.Click += new System.EventHandler(this.btnSubCategory_Click);
            // 
            // bunifuElipseProducts
            // 
            this.bunifuElipseProducts.ElipseRadius = 30;
            this.bunifuElipseProducts.TargetControl = this.btnProducts;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Magenta;
            this.btnProducts.color = System.Drawing.Color.Magenta;
            this.btnProducts.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = global::GYMManagementSystem.Properties.Resources.icons8_box_100;
            this.btnProducts.ImagePosition = 20;
            this.btnProducts.ImageZoom = 50;
            this.btnProducts.LabelPosition = 41;
            this.btnProducts.LabelText = "Products";
            this.btnProducts.Location = new System.Drawing.Point(21, 156);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(6);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(128, 129);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // bunifuElipseMembership
            // 
            this.bunifuElipseMembership.ElipseRadius = 30;
            this.bunifuElipseMembership.TargetControl = this.btnMembership;
            // 
            // btnMembership
            // 
            this.btnMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMembership.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMembership.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnMembership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembership.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembership.ForeColor = System.Drawing.Color.White;
            this.btnMembership.Image = global::GYMManagementSystem.Properties.Resources.icons8_membership_card_100;
            this.btnMembership.ImagePosition = 18;
            this.btnMembership.ImageZoom = 50;
            this.btnMembership.LabelPosition = 38;
            this.btnMembership.LabelText = "Membership";
            this.btnMembership.Location = new System.Drawing.Point(161, 156);
            this.btnMembership.Margin = new System.Windows.Forms.Padding(6);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(128, 129);
            this.btnMembership.TabIndex = 0;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // bunifuElipseClose
            // 
            this.bunifuElipseClose.ElipseRadius = 30;
            this.bunifuElipseClose.TargetControl = this.btnClose;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.color = System.Drawing.Color.OrangeRed;
            this.btnClose.colorActive = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::GYMManagementSystem.Properties.Resources.icons8_close_sign_100;
            this.btnClose.ImagePosition = 20;
            this.btnClose.ImageZoom = 50;
            this.btnClose.LabelPosition = 41;
            this.btnClose.LabelText = "Close";
            this.btnClose.Location = new System.Drawing.Point(90, 297);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 129);
            this.btnClose.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Controls.Add(this.btnMembership);
            this.bunifuGradientPanel1.Controls.Add(this.btnSubCategory);
            this.bunifuGradientPanel1.Controls.Add(this.btnProducts);
            this.bunifuGradientPanel1.Controls.Add(this.btnCategory);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(313, 444);
            this.bunifuGradientPanel1.TabIndex = 5;
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 444);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnClose;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTileButton btnMembership;
        private Bunifu.Framework.UI.BunifuTileButton btnSubCategory;
        private Bunifu.Framework.UI.BunifuTileButton btnProducts;
        private Bunifu.Framework.UI.BunifuTileButton btnCategory;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseForm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseTile1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseSubCategory;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseProducts;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMembership;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseClose;
    }
}