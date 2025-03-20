using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static user_loginSystem._0._1.HesapOlustur;


namespace user_loginSystem._0._1
{
    public partial class GirisYap : Form
    {
        private ArrayList userList;

        public GirisYap(ArrayList userList = null)
        {
            InitializeComponent();
            this.userList = userList ?? new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enter_userName = textBox1.Text;
            string enter_userPassword = textBox2.Text;

            if (string.IsNullOrWhiteSpace(enter_userName) || string.IsNullOrWhiteSpace(enter_userPassword))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
                return;
            }

            foreach (HesapOlustur.User user in userList)
            {
                if (user.UserName == enter_userName && user.UserPassword == enter_userPassword)
                {
                    string userGender = user.UserGender;
                    string userNumber = user.UserNumber;
                    string userSecret = user.UserSecret;

                    KullaniciEkrani kullaniciEkrani = new KullaniciEkrani(enter_userName, userNumber, enter_userPassword, userGender, userSecret);
                    kullaniciEkrani.Show();
                    
                    return;
                }
            }

            MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NumaraMesaj form3 = new NumaraMesaj(userList);
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HesapOlustur hesapOlustur = new HesapOlustur();
            hesapOlustur.Show();
            
        }



        //------------------------------------------------------------------------ Tasarım

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if ("Username" == textBox1.Text)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
  

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Silver;
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if ("Password" == textBox2.Text)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if ("" == textBox2.Text)
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
            }
        }

      
        
    }
}