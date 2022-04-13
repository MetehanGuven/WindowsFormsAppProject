using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace WindowsFormsAppProject
{
    public partial class formadmin : Form
    {
        public formadmin()
        {
            InitializeComponent();
        }
        
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-V0ONND0;Initial Catalog=Kullanıcılar;Integrated Security=True");

        void kullanıcılarılistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Bilgi", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanıcılarılistele();

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            Password.Visible = false;
            Username.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            button5.Visible = false;
            label2.Visible = false;
            textBox9.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new FormGiriş().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            Password.Visible = true;
            Username.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            button5.Visible = true;
            label2.Visible = false;
            textBox9.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            Password.Visible = true;
            Username.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            button5.Visible = false;
            label2.Visible = false;
            textBox9.Visible = false;
            button6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Bilgi  (Username,Password,Name_Surname,Phone_Number,Address,City,Country,E_mail) values (@Username, @Password,@Name_Surname,@Phone_Number,@Address,@City,@Country,@E_mail)", baglan);
            komut.Parameters.AddWithValue("@Username", textBox3.Text);
            komut.Parameters.AddWithValue("@Password", textBox2.Text);
            komut.Parameters.AddWithValue("@Name_Surname", textBox1.Text);
            komut.Parameters.AddWithValue("@Phone_Number", textBox4.Text);
            komut.Parameters.AddWithValue("@Address", textBox5.Text);
            komut.Parameters.AddWithValue("@City", textBox6.Text);
            komut.Parameters.AddWithValue("@Country", textBox7.Text);
            komut.Parameters.AddWithValue("@E_mail", textBox8.Text);
            komut.ExecuteNonQuery();
            kullanıcılarılistele();
            baglan.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox9.Visible = true;
            button6.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            Password.Visible = false;
            Username.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Bilgi where Username='" + textBox9.Text + "'", baglan);
            komut.Parameters.AddWithValue("@Username", textBox9.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            kullanıcılarılistele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("UPDATE Bilgi SET Username='" + textBox3.Text + "',Password='" + textBox2.Text + "', Name_Surname='" + textBox1.Text + "',Phone_Number='" + textBox4.Text + "',Address='" + textBox5.Text + "',City='" + textBox6.Text + "',Country='" + textBox7.Text + "',E_mail='" + textBox8.Text + "'where Username='"+textBox3.Text+"'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            kullanıcılarılistele();
            
        }
    }
}
