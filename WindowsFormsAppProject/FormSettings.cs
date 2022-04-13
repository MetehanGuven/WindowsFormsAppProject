using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppProject.Properties;

namespace WindowsFormsAppProject
{
    public partial class Dif : Form
    {
        public Dif()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtn1.Visible = true;
            txtn2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            lblsum.Visible = true;
            button2.Visible = true;
        }

        private void txtn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int S1 = Convert.ToInt32(txtn1.Text);
            int S2 = Convert.ToInt32(txtn2.Text);
            int sonuc = S1 + S2;
            lblsum.Text = sonuc.ToString();
            Settings2.Default.CustomText1 = txtn1.Text;
            Settings2.Default.CustomText2 = txtn2.Text;
            Settings2.Default.CustomLabel = lblsum.Text;

            Settings2.Default.Save();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtn1.Visible = false;
            txtn2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            lblsum.Visible = false;
            button2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtn1.Visible = false;
            txtn2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            lblsum.Visible = false;
            button2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtn1.Visible = false;
            txtn2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            lblsum.Visible = false;
            button2.Visible = false;
        }

        private void txtn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnap_Click(object sender, EventArgs e)
        {
            Settings2.Default.rdbc = radbcir.Checked;
            Settings2.Default.rdbt = radbtri.Checked;
            Settings2.Default.rdbq = radbsq.Checked;
            Settings2.Default.rdb1 = radioButton1.Checked;
            Settings2.Default.rdb2 = radioButton2.Checked;
            Settings2.Default.rdb3 = radioButton3.Checked;
            Settings2.Default.rdb4 = radioButton4.Checked;
            Settings2.Default.CustomText1 = txtn1.Text;
            Settings2.Default.CustomText2 = txtn2.Text;
            Settings2.Default.CustomLabel = lblsum.Text;

            Settings2.Default.Save();
        }

        private void Dif_Load(object sender, EventArgs e)
        {
            radbsq.Checked = Settings2.Default.rdbq;
            radbtri.Checked = Settings2.Default.rdbt;
            radbcir.Checked = Settings2.Default.rdbc;
            radioButton1.Checked = Settings2.Default.rdb1;
            radioButton2.Checked = Settings2.Default.rdb2;
            radioButton3.Checked = Settings2.Default.rdb3;
            radioButton4.Checked = Settings2.Default.rdb4;
            txtn1.Text = Settings2.Default.CustomText1;
            txtn2.Text = Settings2.Default.CustomText2;
            lblsum.Text = Settings2.Default.CustomLabel;

        }
    }
}
