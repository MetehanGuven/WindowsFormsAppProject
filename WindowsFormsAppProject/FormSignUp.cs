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

namespace WindowsFormsAppProject
{
    public partial class formsign : Form
    {
        public formsign()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-V0ONND0;Initial Catalog=Kullanıcılar;Integrated Security=True");
        private void btncreate_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {


                if (textBox2.Text == textBox9.Text && chcterco.Checked == true)
                {
                    baglanti.Open();
                    string Username, Password, Name_Surname, Phone_Number, Address, City, Country, E_mail;
                    Username = textBox3.Text;
                    Password = textBox2.Text;
                    Name_Surname = textBox1.Text;
                    Phone_Number = textBox4.Text;
                    Address = textBox5.Text;
                    City = textBox6.Text;
                    Country = textBox7.Text;
                    E_mail = textBox8.Text;
                    SqlCommand komut = new SqlCommand("Select *from Bilgi where Username = '" + Username + "'", baglanti);
                    SqlDataReader oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        MessageBox.Show("This username is already in use. Please try another one submit ");
                    }
                    else 
                    {
                        oku.Close();
                        SqlCommand ekle = new SqlCommand("insert into Bilgi(Username,Password,Name_Surname,Phone_Number,Address,City,Country,E_mail) values ('" + Username + "','" + Password + "','" + Name_Surname + "','" + Phone_Number + "','" + Address + "','" + City + "','" + Country + "','" + E_mail + "')", baglanti);
                        ekle.ExecuteNonQuery();
                        MessageBox.Show("You Registered.");
                        new LogSc().Show();
                        this.Hide();
                    }

                    baglanti.Close();

                   
                }

                else if (chcterco.Checked == false)



                {
                    MessageBox.Show("Please check terms and conditions!!");
                }
                
                else if (textBox2.Text != textBox9.Text)
                {
                    label10.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please fill in the required fields !");
            }
            
           
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LogSc().Show();
            this.Hide();
        }

        private void formsign_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
    }
    

