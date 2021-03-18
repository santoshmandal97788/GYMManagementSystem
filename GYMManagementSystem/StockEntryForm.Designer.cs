namespace GYMManagementSystem
{
    partial class StockEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockEntryForm));
            this.bunifuElipseOperation = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanelStockOperation = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabelOperation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDeleteStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddNewStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabelHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelHeading = new System.Windows.Forms.Panel();
            this.bunifuElipseStockDetails = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanelStockInformation = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboSupplierName = new System.Windows.Forms.ComboBox();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.LabelQuantity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LabelSupplierName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LabelProductName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelBorderLine = new System.Windows.Forms.Panel();
            this.LabelStockEntryDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LabelStoxkId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelStockInformation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanelForm = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtQuantityInitial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanelStockOperation.SuspendLayout();
            this.panelHeading.SuspendLayout();
            this.bunifuGradientPanelStockInformation.SuspendLayout();
            this.bunifuGradientPanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipseOperation
            // 
            this.bunifuElipseOperation.ElipseRadius = 20;
            this.bunifuElipseOperation.TargetControl = this.bunifuGradientPanelStockOperation;
            // 
            // bunifuGradientPanelStockOperation
            // 
            this.bunifuGradientPanelStockOperation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelStockOperation.BackgroundImage")));
            this.bunifuGradientPanelStockOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelStockOperation.Controls.Add(this.btnClose);
            this.bunifuGradientPanelStockOperation.Controls.Add(this.panel1);
            this.bunifuGradientPanelStockOperation.Controls.Add(this.btnViewStock);
            this.bunifuGradientPanelStockOperation.Controls.Add(this.bunifuCustomLabelOperation);
            this.bunifuGradientPanelStockOperation.Controls.Add(this.btnDeleteStock);
            this.bunifuGradientPanelStockOperation.Controls.Add(this.btnAddNewStock);
            this.bunifuGradientPanelStockOperation.Controls.Add(this.btnUpdateStock);
            this.bunifuGradientPanelStockOperation.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanelStockOperation.GradientBottomRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanelStockOperation.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelStockOperation.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelStockOperation.Location = new System.Drawing.Point(379, 81);
            this.bunifuGradientPanelStockOperation.Name = "bunifuGradientPanelStockOperation";
            this.bunifuGradientPanelStockOperation.Quality = 10;
            this.bunifuGradientPanelStockOperation.Size = new System.Drawing.Size(216, 299);
            this.bunifuGradientPanelStockOperation.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = null;
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(64, 242);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.OnHovercolor = System.Drawing.Color.Magenta;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(103, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 1);
            this.panel1.TabIndex = 7;
            // 
            // btnViewStock
            // 
            this.btnViewStock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewStock.BorderRadius = 0;
            this.btnViewStock.ButtonText = "View Stock";
            this.btnViewStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewStock.Iconimage = null;
            this.btnViewStock.Iconimage_right = null;
            this.btnViewStock.Iconimage_right_Selected = null;
            this.btnViewStock.Iconimage_Selected = null;
            this.btnViewStock.IconMarginLeft = 0;
            this.btnViewStock.IconMarginRight = 0;
            this.btnViewStock.IconRightVisible = true;
            this.btnViewStock.IconRightZoom = 0D;
            this.btnViewStock.IconVisible = true;
            this.btnViewStock.IconZoom = 90D;
            this.btnViewStock.IsTab = false;
            this.btnViewStock.Location = new System.Drawing.Point(65, 190);
            this.btnViewStock.Margin = new System.Windows.Forms.Padding(6);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewStock.OnHovercolor = System.Drawing.Color.Magenta;
            this.btnViewStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewStock.selected = false;
            this.btnViewStock.Size = new System.Drawing.Size(102, 40);
            this.btnViewStock.TabIndex = 7;
            this.btnViewStock.Text = "View Stock";
            this.btnViewStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewStock.Textcolor = System.Drawing.Color.White;
            this.btnViewStock.TextFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click);
            // 
            // bunifuCustomLabelOperation
            // 
            this.bunifuCustomLabelOperation.AutoSize = true;
            this.bunifuCustomLabelOperation.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabelOperation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabelOperation.Location = new System.Drawing.Point(40, 0);
            this.bunifuCustomLabelOperation.Name = "bunifuCustomLabelOperation";
            this.bunifuCustomLabelOperation.Size = new System.Drawing.Size(137, 18);
            this.bunifuCustomLabelOperation.TabIndex = 3;
            this.bunifuCustomLabelOperation.Text = "Perform Operation";
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteStock.BorderRadius = 0;
            this.btnDeleteStock.ButtonText = "Delete";
            this.btnDeleteStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteStock.Iconimage = null;
            this.btnDeleteStock.Iconimage_right = null;
            this.btnDeleteStock.Iconimage_right_Selected = null;
            this.btnDeleteStock.Iconimage_Selected = null;
            this.btnDeleteStock.IconMarginLeft = 0;
            this.btnDeleteStock.IconMarginRight = 0;
            this.btnDeleteStock.IconRightVisible = true;
            this.btnDeleteStock.IconRightZoom = 0D;
            this.btnDeleteStock.IconVisible = true;
            this.btnDeleteStock.IconZoom = 90D;
            this.btnDeleteStock.IsTab = false;
            this.btnDeleteStock.Location = new System.Drawing.Point(64, 138);
            this.btnDeleteStock.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteStock.OnHovercolor = System.Drawing.Color.Magenta;
            this.btnDeleteStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteStock.selected = false;
            this.btnDeleteStock.Size = new System.Drawing.Size(103, 40);
            this.btnDeleteStock.TabIndex = 6;
            this.btnDeleteStock.Text = "Delete";
            this.btnDeleteStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteStock.Textcolor = System.Drawing.Color.White;
            this.btnDeleteStock.TextFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // btnAddNewStock
            // 
            this.btnAddNewStock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddNewStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddNewStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewStock.BorderRadius = 0;
            this.btnAddNewStock.ButtonText = "ADD";
            this.btnAddNewStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddNewStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddNewStock.Iconimage = null;
            this.btnAddNewStock.Iconimage_right = null;
            this.btnAddNewStock.Iconimage_right_Selected = null;
            this.btnAddNewStock.Iconimage_Selected = null;
            this.btnAddNewStock.IconMarginLeft = 0;
            this.btnAddNewStock.IconMarginRight = 0;
            this.btnAddNewStock.IconRightVisible = true;
            this.btnAddNewStock.IconRightZoom = 0D;
            this.btnAddNewStock.IconVisible = true;
            this.btnAddNewStock.IconZoom = 90D;
            this.btnAddNewStock.IsTab = false;
            this.btnAddNewStock.Location = new System.Drawing.Point(64, 31);
            this.btnAddNewStock.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddNewStock.Name = "btnAddNewStock";
            this.btnAddNewStock.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddNewStock.OnHovercolor = System.Drawing.Color.Magenta;
            this.btnAddNewStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddNewStock.selected = false;
            this.btnAddNewStock.Size = new System.Drawing.Size(103, 40);
            this.btnAddNewStock.TabIndex = 4;
            this.btnAddNewStock.Text = "ADD";
            this.btnAddNewStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewStock.Textcolor = System.Drawing.Color.White;
            this.btnAddNewStock.TextFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStock.Click += new System.EventHandler(this.btnAddNewStock_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateStock.BorderRadius = 0;
            this.btnUpdateStock.ButtonText = "Update";
            this.btnUpdateStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateStock.Iconimage = null;
            this.btnUpdateStock.Iconimage_right = null;
            this.btnUpdateStock.Iconimage_right_Selected = null;
            this.btnUpdateStock.Iconimage_Selected = null;
            this.btnUpdateStock.IconMarginLeft = 0;
            this.btnUpdateStock.IconMarginRight = 0;
            this.btnUpdateStock.IconRightVisible = true;
            this.btnUpdateStock.IconRightZoom = 0D;
            this.btnUpdateStock.IconVisible = true;
            this.btnUpdateStock.IconZoom = 90D;
            this.btnUpdateStock.IsTab = false;
            this.btnUpdateStock.Location = new System.Drawing.Point(64, 86);
            this.btnUpdateStock.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateStock.OnHovercolor = System.Drawing.Color.Magenta;
            this.btnUpdateStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateStock.selected = false;
            this.btnUpdateStock.Size = new System.Drawing.Size(103, 40);
            this.btnUpdateStock.TabIndex = 5;
            this.btnUpdateStock.Text = "Update";
            this.btnUpdateStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateStock.Textcolor = System.Drawing.Color.White;
            this.btnUpdateStock.TextFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // bunifuCustomLabelHeading
            // 
            this.bunifuCustomLabelHeading.AutoSize = true;
            this.bunifuCustomLabelHeading.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelHeading.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelHeading.Location = new System.Drawing.Point(163, 9);
            this.bunifuCustomLabelHeading.Name = "bunifuCustomLabelHeading";
            this.bunifuCustomLabelHeading.Size = new System.Drawing.Size(293, 25);
            this.bunifuCustomLabelHeading.TabIndex = 0;
            this.bunifuCustomLabelHeading.Text = "XYZ GYM CLUB Stock Entry Form";
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeading.Controls.Add(this.bunifuCustomLabelHeading);
            this.panelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeading.Location = new System.Drawing.Point(0, 0);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(621, 45);
            this.panelHeading.TabIndex = 4;
            // 
            // bunifuElipseStockDetails
            // 
            this.bunifuElipseStockDetails.ElipseRadius = 20;
            this.bunifuElipseStockDetails.TargetControl = this.bunifuGradientPanelStockInformation;
            // 
            // bunifuGradientPanelStockInformation
            // 
            this.bunifuGradientPanelStockInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelStockInformation.BackgroundImage")));
            this.bunifuGradientPanelStockInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelStockInformation.Controls.Add(this.txtStockID);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.txtQuantityInitial);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.txtStockNo);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.dateTimePicker1);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.cboSupplierName);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.cboProductName);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.LabelQuantity);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.LabelSupplierName);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.txtQuantity);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.LabelProductName);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.panelBorderLine);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.LabelStockEntryDate);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.LabelStoxkId);
            this.bunifuGradientPanelStockInformation.Controls.Add(this.labelStockInformation);
            this.bunifuGradientPanelStockInformation.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanelStockInformation.GradientBottomRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanelStockInformation.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelStockInformation.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelStockInformation.Location = new System.Drawing.Point(22, 81);
            this.bunifuGradientPanelStockInformation.Name = "bunifuGradientPanelStockInformation";
            this.bunifuGradientPanelStockInformation.Quality = 10;
            this.bunifuGradientPanelStockInformation.Size = new System.Drawing.Size(340, 299);
            this.bunifuGradientPanelStockInformation.TabIndex = 5;
            // 
            // txtStockNo
            // 
            this.txtStockNo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockNo.Location = new System.Drawing.Point(146, 39);
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.ReadOnly = true;
            this.txtStockNo.Size = new System.Drawing.Size(124, 21);
            this.txtStockNo.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cboSupplierName
            // 
            this.cboSupplierName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupplierName.FormattingEnabled = true;
            this.cboSupplierName.Location = new System.Drawing.Point(149, 185);
            this.cboSupplierName.Name = "cboSupplierName";
            this.cboSupplierName.Size = new System.Drawing.Size(188, 24);
            this.cboSupplierName.TabIndex = 2;
            // 
            // cboProductName
            // 
            this.cboProductName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(146, 133);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(191, 24);
            this.cboProductName.TabIndex = 1;
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.AutoSize = true;
            this.LabelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.LabelQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuantity.Location = new System.Drawing.Point(70, 242);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(61, 16);
            this.LabelQuantity.TabIndex = 7;
            this.LabelQuantity.Text = "Quantity:";
            // 
            // LabelSupplierName
            // 
            this.LabelSupplierName.AutoSize = true;
            this.LabelSupplierName.BackColor = System.Drawing.Color.Transparent;
            this.LabelSupplierName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSupplierName.Location = new System.Drawing.Point(35, 190);
            this.LabelSupplierName.Name = "LabelSupplierName";
            this.LabelSupplierName.Size = new System.Drawing.Size(97, 16);
            this.LabelSupplierName.TabIndex = 7;
            this.LabelSupplierName.Text = "Supplier Name:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantity.HintText = "";
            this.txtQuantity.isPassword = false;
            this.txtQuantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuantity.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQuantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuantity.LineThickness = 3;
            this.txtQuantity.Location = new System.Drawing.Point(149, 242);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(133, 21);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // LabelProductName
            // 
            this.LabelProductName.AutoSize = true;
            this.LabelProductName.BackColor = System.Drawing.Color.Transparent;
            this.LabelProductName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductName.Location = new System.Drawing.Point(37, 138);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(95, 16);
            this.LabelProductName.TabIndex = 8;
            this.LabelProductName.Text = "Product Name:";
            // 
            // panelBorderLine
            // 
            this.panelBorderLine.Location = new System.Drawing.Point(0, 21);
            this.panelBorderLine.Name = "panelBorderLine";
            this.panelBorderLine.Size = new System.Drawing.Size(340, 1);
            this.panelBorderLine.TabIndex = 4;
            // 
            // LabelStockEntryDate
            // 
            this.LabelStockEntryDate.AutoSize = true;
            this.LabelStockEntryDate.BackColor = System.Drawing.Color.Transparent;
            this.LabelStockEntryDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStockEntryDate.Location = new System.Drawing.Point(93, 86);
            this.LabelStockEntryDate.Name = "LabelStockEntryDate";
            this.LabelStockEntryDate.Size = new System.Drawing.Size(39, 16);
            this.LabelStockEntryDate.TabIndex = 1;
            this.LabelStockEntryDate.Text = "Date:";
            // 
            // LabelStoxkId
            // 
            this.LabelStoxkId.AutoSize = true;
            this.LabelStoxkId.BackColor = System.Drawing.Color.Transparent;
            this.LabelStoxkId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStoxkId.Location = new System.Drawing.Point(70, 39);
            this.LabelStoxkId.Name = "LabelStoxkId";
            this.LabelStoxkId.Size = new System.Drawing.Size(62, 16);
            this.LabelStoxkId.TabIndex = 1;
            this.LabelStoxkId.Text = "Stock ID:";
            // 
            // labelStockInformation
            // 
            this.labelStockInformation.AutoSize = true;
            this.labelStockInformation.BackColor = System.Drawing.Color.Transparent;
            this.labelStockInformation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelStockInformation.Location = new System.Drawing.Point(111, 0);
            this.labelStockInformation.Name = "labelStockInformation";
            this.labelStockInformation.Size = new System.Drawing.Size(101, 18);
            this.labelStockInformation.TabIndex = 3;
            this.labelStockInformation.Text = "Stock Details";
            // 
            // bunifuElipseForm
            // 
            this.bunifuElipseForm.ElipseRadius = 45;
            this.bunifuElipseForm.TargetControl = this;
            // 
            // bunifuGradientPanelForm
            // 
            this.bunifuGradientPanelForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelForm.BackgroundImage")));
            this.bunifuGradientPanelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelForm.Controls.Add(this.bunifuGradientPanelStockOperation);
            this.bunifuGradientPanelForm.Controls.Add(this.bunifuGradientPanelStockInformation);
            this.bunifuGradientPanelForm.Controls.Add(this.panelHeading);
            this.bunifuGradientPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanelForm.GradientBottomLeft = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanelForm.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanelForm.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelForm.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelForm.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelForm.Name = "bunifuGradientPanelForm";
            this.bunifuGradientPanelForm.Quality = 10;
            this.bunifuGradientPanelForm.Size = new System.Drawing.Size(621, 416);
            this.bunifuGradientPanelForm.TabIndex = 1;
            // 
            // txtQuantityInitial
            // 
            this.txtQuantityInitial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantityInitial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQuantityInitial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantityInitial.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantityInitial.HintText = "";
            this.txtQuantityInitial.isPassword = false;
            this.txtQuantityInitial.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuantityInitial.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQuantityInitial.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuantityInitial.LineThickness = 3;
            this.txtQuantityInitial.Location = new System.Drawing.Point(149, 271);
            this.txtQuantityInitial.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantityInitial.Name = "txtQuantityInitial";
            this.txtQuantityInitial.Size = new System.Drawing.Size(133, 21);
            this.txtQuantityInitial.TabIndex = 19;
            this.txtQuantityInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantityInitial.Visible = false;
            // 
            // txtStockID
            // 
            this.txtStockID.Location = new System.Drawing.Point(260, 66);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(60, 20);
            this.txtStockID.TabIndex = 20;
            this.txtStockID.Visible = false;
            // 
            // StockEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 416);
            this.Controls.Add(this.bunifuGradientPanelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockEntryForm";
            this.Load += new System.EventHandler(this.StockEntryForm_Load);
            this.bunifuGradientPanelStockOperation.ResumeLayout(false);
            this.bunifuGradientPanelStockOperation.PerformLayout();
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            this.bunifuGradientPanelStockInformation.ResumeLayout(false);
            this.bunifuGradientPanelStockInformation.PerformLayout();
            this.bunifuGradientPanelForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipseOperation;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelStockOperation;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewStock;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelOperation;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelHeading;
        private System.Windows.Forms.Panel panelHeading;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseStockDetails;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelStockInformation;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelSupplierName;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelProductName;
        private System.Windows.Forms.Panel panelBorderLine;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelStockEntryDate;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelStoxkId;
        private Bunifu.Framework.UI.BunifuCustomLabel labelStockInformation;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseForm;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox cboSupplierName;
        public System.Windows.Forms.ComboBox cboProductName;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantity;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelForm;
        public System.Windows.Forms.TextBox txtStockNo;
        public Bunifu.Framework.UI.BunifuFlatButton btnDeleteStock;
        public Bunifu.Framework.UI.BunifuFlatButton btnAddNewStock;
        public Bunifu.Framework.UI.BunifuFlatButton btnUpdateStock;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantityInitial;
        internal System.Windows.Forms.TextBox txtStockID;
    }
}