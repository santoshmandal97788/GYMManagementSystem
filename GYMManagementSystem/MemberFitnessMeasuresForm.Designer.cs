namespace GYMManagementSystem
{
    partial class MemberFitnessMeasuresForm
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label DateOutLabel;
            System.Windows.Forms.Label DateInLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberFitnessMeasuresForm));
            this.bunifuElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanelMemberInformation = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBoxMemberImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.LabelContact = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LabelEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtContact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LabelCity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LabelAddress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelBorderLine = new System.Windows.Forms.Panel();
            this.LabelGender = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LabelMemberName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelMemberInformation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtM_ID = new System.Windows.Forms.TextBox();
            this.txtMembershipType = new System.Windows.Forms.TextBox();
            this.txtMembershipID = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelHeading = new System.Windows.Forms.Panel();
            this.bunifuCustomLabelHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            DateOutLabel = new System.Windows.Forms.Label();
            DateInLabel = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanelMemberInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemberImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.panelHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(25, 132);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(97, 13);
            label5.TabIndex = 295;
            label5.Text = "Membership Type :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(25, 25);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(84, 13);
            label6.TabIndex = 294;
            label6.Text = "Membership ID :";
            // 
            // DateOutLabel
            // 
            DateOutLabel.AutoSize = true;
            DateOutLabel.ForeColor = System.Drawing.Color.Black;
            DateOutLabel.Location = new System.Drawing.Point(24, 184);
            DateOutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DateOutLabel.Name = "DateOutLabel";
            DateOutLabel.Size = new System.Drawing.Size(52, 13);
            DateOutLabel.TabIndex = 249;
            DateOutLabel.Text = "Date To :";
            // 
            // DateInLabel
            // 
            DateInLabel.AutoSize = true;
            DateInLabel.ForeColor = System.Drawing.Color.Black;
            DateInLabel.Location = new System.Drawing.Point(24, 158);
            DateInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DateInLabel.Name = "DateInLabel";
            DateInLabel.Size = new System.Drawing.Size(62, 13);
            DateInLabel.TabIndex = 247;
            DateInLabel.Text = "Date From :";
            // 
            // bunifuElipseForm
            // 
            this.bunifuElipseForm.ElipseRadius = 45;
            this.bunifuElipseForm.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanelMemberInformation);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox2);
            this.bunifuGradientPanel1.Controls.Add(this.panelHeading);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(838, 520);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuGradientPanelMemberInformation
            // 
            this.bunifuGradientPanelMemberInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelMemberInformation.BackgroundImage")));
            this.bunifuGradientPanelMemberInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.pictureBoxMemberImage);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.btnBrowseImage);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.radioButtonOther);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.radioButtonFemale);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.radioButtonMale);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.LabelContact);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.LabelEmail);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.txtContact);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.LabelCity);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.txtEmail);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.LabelAddress);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.bunifuMaterialTextbox1);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.bunifuMaterialTextbox2);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.panelBorderLine);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.LabelGender);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.bunifuMaterialTextbox3);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.LabelMemberName);
            this.bunifuGradientPanelMemberInformation.Controls.Add(this.labelMemberInformation);
            this.bunifuGradientPanelMemberInformation.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanelMemberInformation.GradientBottomRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanelMemberInformation.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelMemberInformation.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelMemberInformation.Location = new System.Drawing.Point(27, 51);
            this.bunifuGradientPanelMemberInformation.Name = "bunifuGradientPanelMemberInformation";
            this.bunifuGradientPanelMemberInformation.Quality = 10;
            this.bunifuGradientPanelMemberInformation.Size = new System.Drawing.Size(340, 457);
            this.bunifuGradientPanelMemberInformation.TabIndex = 297;
            // 
            // pictureBoxMemberImage
            // 
            this.pictureBoxMemberImage.Location = new System.Drawing.Point(119, 210);
            this.pictureBoxMemberImage.Name = "pictureBoxMemberImage";
            this.pictureBoxMemberImage.Size = new System.Drawing.Size(185, 154);
            this.pictureBoxMemberImage.TabIndex = 18;
            this.pictureBoxMemberImage.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseImage.BorderRadius = 0;
            this.btnBrowseImage.ButtonText = "Browse Image";
            this.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseImage.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowseImage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowseImage.Iconimage = null;
            this.btnBrowseImage.Iconimage_right = null;
            this.btnBrowseImage.Iconimage_right_Selected = null;
            this.btnBrowseImage.Iconimage_Selected = null;
            this.btnBrowseImage.IconMarginLeft = 0;
            this.btnBrowseImage.IconMarginRight = 0;
            this.btnBrowseImage.IconRightVisible = true;
            this.btnBrowseImage.IconRightZoom = 0D;
            this.btnBrowseImage.IconVisible = true;
            this.btnBrowseImage.IconZoom = 90D;
            this.btnBrowseImage.IsTab = false;
            this.btnBrowseImage.Location = new System.Drawing.Point(120, 373);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowseImage.OnHovercolor = System.Drawing.Color.Magenta;
            this.btnBrowseImage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowseImage.selected = false;
            this.btnBrowseImage.Size = new System.Drawing.Size(137, 40);
            this.btnBrowseImage.TabIndex = 9;
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowseImage.Textcolor = System.Drawing.Color.White;
            this.btnBrowseImage.TextFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOther.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButtonOther.Location = new System.Drawing.Point(283, 95);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(57, 20);
            this.radioButtonOther.TabIndex = 5;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFemale.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButtonFemale.Location = new System.Drawing.Point(192, 95);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(65, 20);
            this.radioButtonFemale.TabIndex = 4;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMale.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButtonMale.Location = new System.Drawing.Point(119, 95);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(54, 20);
            this.radioButtonMale.TabIndex = 3;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = false;
            // 
            // LabelContact
            // 
            this.LabelContact.AutoSize = true;
            this.LabelContact.BackColor = System.Drawing.Color.Transparent;
            this.LabelContact.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContact.Location = new System.Drawing.Point(52, 182);
            this.LabelContact.Name = "LabelContact";
            this.LabelContact.Size = new System.Drawing.Size(57, 16);
            this.LabelContact.TabIndex = 7;
            this.LabelContact.Text = "Contact:";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(64, 153);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(45, 16);
            this.LabelEmail.TabIndex = 7;
            this.LabelEmail.Text = "Email:";
            // 
            // txtContact
            // 
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContact.HintForeColor = System.Drawing.Color.Empty;
            this.txtContact.HintText = "";
            this.txtContact.isPassword = false;
            this.txtContact.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtContact.LineIdleColor = System.Drawing.Color.Gray;
            this.txtContact.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtContact.LineThickness = 3;
            this.txtContact.Location = new System.Drawing.Point(119, 182);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(204, 21);
            this.txtContact.TabIndex = 8;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.BackColor = System.Drawing.Color.Transparent;
            this.LabelCity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCity.Location = new System.Drawing.Point(71, 128);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(35, 16);
            this.LabelCity.TabIndex = 7;
            this.LabelCity.Text = "City:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(119, 153);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 21);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(46, 64);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(60, 16);
            this.LabelAddress.TabIndex = 8;
            this.LabelAddress.Text = "Address:";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(119, 124);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(204, 21);
            this.bunifuMaterialTextbox1.TabIndex = 6;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(119, 64);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(204, 21);
            this.bunifuMaterialTextbox2.TabIndex = 2;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelBorderLine
            // 
            this.panelBorderLine.Location = new System.Drawing.Point(0, 21);
            this.panelBorderLine.Name = "panelBorderLine";
            this.panelBorderLine.Size = new System.Drawing.Size(340, 1);
            this.panelBorderLine.TabIndex = 4;
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.BackColor = System.Drawing.Color.Transparent;
            this.LabelGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGender.Location = new System.Drawing.Point(52, 95);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(54, 16);
            this.LabelGender.TabIndex = 1;
            this.LabelGender.Text = "Gender:";
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(119, 34);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(204, 21);
            this.bunifuMaterialTextbox3.TabIndex = 1;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LabelMemberName
            // 
            this.LabelMemberName.AutoSize = true;
            this.LabelMemberName.BackColor = System.Drawing.Color.Transparent;
            this.LabelMemberName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMemberName.Location = new System.Drawing.Point(9, 34);
            this.LabelMemberName.Name = "LabelMemberName";
            this.LabelMemberName.Size = new System.Drawing.Size(97, 16);
            this.LabelMemberName.TabIndex = 1;
            this.LabelMemberName.Text = "Member Name:";
            // 
            // labelMemberInformation
            // 
            this.labelMemberInformation.AutoSize = true;
            this.labelMemberInformation.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberInformation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelMemberInformation.Location = new System.Drawing.Point(94, 0);
            this.labelMemberInformation.Name = "labelMemberInformation";
            this.labelMemberInformation.Size = new System.Drawing.Size(146, 18);
            this.labelMemberInformation.TabIndex = 3;
            this.labelMemberInformation.Text = "Member Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtM_ID);
            this.groupBox2.Controls.Add(this.txtMembershipType);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(this.txtMembershipID);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(this.Picture);
            this.groupBox2.Controls.Add(this.txtMemberName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpDateTo);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(DateOutLabel);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.dtpDateFrom);
            this.groupBox2.Controls.Add(DateInLabel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(436, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 222);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Membership Info";
            // 
            // txtM_ID
            // 
            this.txtM_ID.Location = new System.Drawing.Point(303, 186);
            this.txtM_ID.Name = "txtM_ID";
            this.txtM_ID.ReadOnly = true;
            this.txtM_ID.Size = new System.Drawing.Size(70, 20);
            this.txtM_ID.TabIndex = 6;
            this.txtM_ID.Visible = false;
            // 
            // txtMembershipType
            // 
            this.txtMembershipType.BackColor = System.Drawing.SystemColors.Control;
            this.txtMembershipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembershipType.Location = new System.Drawing.Point(143, 132);
            this.txtMembershipType.Name = "txtMembershipType";
            this.txtMembershipType.ReadOnly = true;
            this.txtMembershipType.Size = new System.Drawing.Size(211, 21);
            this.txtMembershipType.TabIndex = 296;
            // 
            // txtMembershipID
            // 
            this.txtMembershipID.Location = new System.Drawing.Point(143, 25);
            this.txtMembershipID.Name = "txtMembershipID";
            this.txtMembershipID.ReadOnly = true;
            this.txtMembershipID.Size = new System.Drawing.Size(70, 20);
            this.txtMembershipID.TabIndex = 0;
            // 
            // Picture
            // 
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Location = new System.Drawing.Point(360, 26);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(186, 152);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 292;
            this.Picture.TabStop = false;
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.SystemColors.Control;
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(143, 52);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(211, 21);
            this.txtMemberName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "City :";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(142, 184);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(121, 20);
            this.dtpDateTo.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Control;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(143, 105);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(157, 21);
            this.txtCity.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(143, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(211, 21);
            this.txtAddress.TabIndex = 2;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(142, 158);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(121, 20);
            this.dtpDateFrom.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Address :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Member Name :";
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeading.Controls.Add(this.bunifuCustomLabelHeading);
            this.panelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeading.Location = new System.Drawing.Point(0, 0);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(838, 45);
            this.panelHeading.TabIndex = 7;
            // 
            // bunifuCustomLabelHeading
            // 
            this.bunifuCustomLabelHeading.AutoSize = true;
            this.bunifuCustomLabelHeading.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelHeading.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelHeading.Location = new System.Drawing.Point(211, 9);
            this.bunifuCustomLabelHeading.Name = "bunifuCustomLabelHeading";
            this.bunifuCustomLabelHeading.Size = new System.Drawing.Size(407, 25);
            this.bunifuCustomLabelHeading.TabIndex = 0;
            this.bunifuCustomLabelHeading.Text = "XYZ GYM CLUB Membership Fitness Measures\r\n";
            // 
            // MemberFitnessMeasuresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 520);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberFitnessMeasuresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberFitnessMeasuresForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanelMemberInformation.ResumeLayout(false);
            this.bunifuGradientPanelMemberInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemberImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipseForm;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panelHeading;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelHeading;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtM_ID;
        internal System.Windows.Forms.TextBox txtMembershipType;
        internal System.Windows.Forms.TextBox txtMembershipID;
        public System.Windows.Forms.PictureBox Picture;
        internal System.Windows.Forms.TextBox txtMemberName;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelMemberInformation;
        private System.Windows.Forms.PictureBox pictureBoxMemberImage;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseImage;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelContact;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContact;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelCity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Panel panelBorderLine;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelGender;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelMemberName;
        private Bunifu.Framework.UI.BunifuCustomLabel labelMemberInformation;
    }
}