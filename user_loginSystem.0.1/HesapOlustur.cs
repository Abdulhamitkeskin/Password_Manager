using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace user_loginSystem._0._1
{
    public partial class HesapOlustur : Form
    {
        public string userName, userNumber, userPassword, userGender, userSecret;

        public HesapOlustur()
        {
            InitializeComponent();
        }

        public struct User
        {
            public string UserName { get; set; }
            public string UserNumber { get; set; }
            public string UserPassword { get; set; }
            public string UserGender { get; set; }
            public string UserSecret { get; set; }

            public User(string userName, string userNumber, string userPassword, string userGender, string userSecret)
            {
                UserName = userName;
                UserNumber = userNumber;
                UserPassword = userPassword;
                UserGender = userGender;
                UserSecret = userSecret;
            }
        }

        public ArrayList userList = new ArrayList();

        public void button1_Click(object sender, EventArgs e)
        {
            userName = textBox1.Text;
            userNumber = textBox2.Text;
            userPassword = textBox3.Text;
            userGender = comboBox1.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userGender) || string.IsNullOrWhiteSpace(userNumber) || string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            else
            {
                // formda gözükme işlemleri
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                comboBox1.Visible = false;
                button1.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                textBox4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userSecret = textBox4.Text;

            User user = new User(userName, userNumber, userPassword, userGender, userSecret);

            userList.Add(user);

            GirisYap girisYap = new GirisYap(userList);
            girisYap.Show();
            ;
        }





        //-------------------------------------------------------  Tasarım

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if ("Name & Surname" == textBox1.Text)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if ("" == textBox1.Text)
            {
                textBox1.Text = "Name & Surname";
                textBox1.ForeColor = Color.Silver;
            }

        }

       

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if ("Number" == textBox2.Text)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

      

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if ("" == textBox2.Text)
            {
                textBox2.Text = "Number";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if ("Password" == textBox3.Text)
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if ("" == textBox3.Text)
            {
                textBox3.Text = "Password";
                textBox3.ForeColor = Color.Silver;
            }
        }

    }
}