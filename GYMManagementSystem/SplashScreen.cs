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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value == 10)
            {
                labelLoading.Text = "Initializing modules";
                labelHeading.Text = "XYZ";
            }
            else if (progressBar1.Value == 20)
            {
                labelLoading.Text = "Loading Files";
                labelHeading.Text = "XYZ GYM";
                labelHeading.ForeColor = Color.Yellow;
            }
            else if (progressBar1.Value == 30)
            {
                labelLoading.Text = "Reading Files";
                labelHeading.Text = "XYZ GYM Management";
                labelHeading.ForeColor = Color.BlueViolet;
            }
            else if (progressBar1.Value == 40)
            {
                labelLoading.Text = "Reading modules";
                labelHeading.Text = "XYZ GYM Management System";
                labelHeading.ForeColor = Color.Tomato;
            }
            else if (progressBar1.Value == 50)
            {
                labelLoading.Text = "Reading Files";
            }
            else if (progressBar1.Value == 60)
            {
                labelLoading.Text = "Reading Files";
            }
            else if (progressBar1.Value == 70)
            {
                labelLoading.Text = "Reading Files";
            }
            else if (progressBar1.Value == 80)
            {
                labelLoading.Text = "Reading Files";
            }
            else if (progressBar1.Value == 90)
            {
                labelLoading.Text = "Reading library Files";
            }
            else if (progressBar1.Value == 100)
            {
                LogInForm lgfrm = new LogInForm();
                lgfrm.Show();
                timer1.Enabled = false;
                this.Hide();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //progressBar1.Width = labelLoading.Width;
        }
    }
}
