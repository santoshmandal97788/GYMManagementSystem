namespace GYMManagementSystem
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.bunifuElipseTile1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseSubCategory = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseProducts = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseMembership = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseClose = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnRestore = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBackup = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipseTile1
            // 
            this.bunifuElipseTile1.ElipseRadius = 30;
            this.bunifuElipseTile1.TargetControl = this.btnBackup;
            // 
            // bunifuElipseSubCategory
            // 
            this.bunifuElipseSubCategory.ElipseRadius = 30;
            this.bunifuElipseSubCategory.TargetControl = this.btnRestore;
            // 
            // bunifuElipseForm
            // 
            this.bunifuElipseForm.ElipseRadius = 55;
            this.bunifuElipseForm.TargetControl = this;
            // 
            // bunifuElipseProducts
            // 
            this.bunifuElipseProducts.ElipseRadius = 30;
            this.bunifuElipseProducts.TargetControl = this;
            // 
            // bunifuElipseMembership
            // 
            this.bunifuElipseMembership.ElipseRadius = 30;
            this.bunifuElipseMembership.TargetControl = this;
            // 
            // bunifuElipseClose
            // 
            this.bunifuElipseClose.ElipseRadius = 30;
            this.bunifuElipseClose.TargetControl = this.btnClose;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Controls.Add(this.btnRestore);
            this.bunifuGradientPanel1.Controls.Add(this.btnBackup);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(443, 162);
            this.bunifuGradientPanel1.TabIndex = 11;
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
            this.btnClose.LabelText = "CLose";
            this.btnClose.Location = new System.Drawing.Point(295, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 129);
            this.btnClose.TabIndex = 0;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRestore.color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRestore.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Image = global::GYMManagementSystem.Properties.Resources.icons8_restart_100;
            this.btnRestore.ImagePosition = 20;
            this.btnRestore.ImageZoom = 50;
            this.btnRestore.LabelPosition = 41;
            this.btnRestore.LabelText = "Restore";
            this.btnRestore.Location = new System.Drawing.Point(155, 15);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(6);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(128, 129);
            this.btnRestore.TabIndex = 0;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBackup.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBackup.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Image = global::GYMManagementSystem.Properties.Resources.icons8_data_backup_100;
            this.btnBackup.ImagePosition = 20;
            this.btnBackup.ImageZoom = 50;
            this.btnBackup.LabelPosition = 41;
            this.btnBackup.LabelText = "Backup";
            this.btnBackup.Location = new System.Drawing.Point(15, 15);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(128, 129);
            this.btnBackup.TabIndex = 0;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 162);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTileButton btnClose;
        private Bunifu.Framework.UI.BunifuTileButton btnRestore;
        private Bunifu.Framework.UI.BunifuTileButton btnBackup;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseTile1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseSubCategory;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseForm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseProducts;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMembership;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseClose;
    }
}