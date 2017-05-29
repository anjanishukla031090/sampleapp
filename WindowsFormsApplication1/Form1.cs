using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclick_Click_1(object sender, EventArgs e)
        {
            string Url = txtText.Text;
            if (string.IsNullOrEmpty(txtText.Text))
            {
                MessageBox.Show("Please enter link!");
                return;
            }

            bool Flag = HasConnection();
            if (Flag == false)
            {
                MessageBox.Show("Internet not available!");
                return;
            }
            System.Diagnostics.Process.Start(Url);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool HasConnection()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtText.Text = "www.google.com";
            btnclick.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtText.Text.Length > 0)
            {
                txtText.Text = "";
            }
            else
            {
                MessageBox.Show("Already clear!");
                return;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }
    }

}



