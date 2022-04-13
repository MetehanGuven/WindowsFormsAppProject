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
using System.Data.SqlClient;
using System.Data.Sql;



namespace WindowsFormsAppProject
{
    public partial class LogSc : Form
    {
        SqlConnection baglan;
        SqlDataReader oku;
        SqlCommand komut;
        public LogSc()
        {
            InitializeComponent();
        }
       
        
        private void Login_Click(object sender, EventArgs e)
        {
            if (user.Text == "user" && pass.Text == "user")
            {
                new Main().Show();
                this.Hide();            
            }
            else if (user.Text == "admin" && pass.Text == "admin")
            {
                new Main().Show();
                this.Hide();               
            }
            string Username = user.Text;
            string Password = pass.Text;
            baglan = new SqlConnection(@"Data Source=DESKTOP-V0ONND0;Initial Catalog=Kullanıcılar;Integrated Security=True");
            komut = new SqlCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "Select *From Bilgi where Username ='" + user.Text + "'And Password = '" + pass.Text + "'";
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                new Main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Wrong username or password !!");
            }

            Settings2.Default.usernameS = user.Text;
            Settings2.Default.Save();

        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login.PerformClick();
            }
        }

        private void EntSc_Load(object sender, EventArgs e)
        {
            user.Focus();
            this.AcceptButton = this.Login;

            user.Text = Settings2.Default.usernameS;
            
               
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new formsign().Show();
            this.Hide();
            
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.PasswordChar = '\0';
            }
           
            else
            {
                pass.PasswordChar = '*';
            }
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }


    }
  
}
