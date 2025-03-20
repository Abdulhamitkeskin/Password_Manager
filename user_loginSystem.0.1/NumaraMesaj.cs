using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_loginSystem._0._1
{
    public partial class NumaraMesaj : Form
    {
        private ArrayList userList;

        public NumaraMesaj(ArrayList userList)
        {
            InitializeComponent();
            this.userList = userList ?? new ArrayList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciSozlesmesi form4 = new KullaniciSozlesmesi();
            form4.Show();
        }

        int random_number;
        string enterUser_number;

        private void button1_Click(object sender, EventArgs e)
        {
            bool control = false;
            if (checkBox1.Checked)
            {
                enterUser_number = textBox1.Text;

                foreach (HesapOlustur.User user in userList)
                {
                    if (user.UserNumber == enterUser_number)
                    {
                        Random rdm = new Random();
                        random_number = rdm.Next(100000, 999999);
                        MessageBox.Show($"Tek kullanımlık şifreniz: {random_number}");
                        control = true;

                        // Tasarım
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        button1.Visible = false;
                        checkBox1.Visible = false;
                        linkLabel1.Visible = false;
                        textBox1.Visible = false;
                        pictureBox1.Visible = false;
                        comboBox1.Visible = false;

                        // Geçiş
                        label4.Visible = true;
                        label5.Visible = true;
                        pictureBox2.Visible = true;
                        textBox2.Visible = true;
                        button2.Visible = true;
                    }
                }

                if (!control)
                {
                    MessageBox.Show("Böyle bir numara bulunmamaktadır");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Sözleşmesini doğrulayın");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox2.Text) == random_number)
                {
                    // Geçişler
                    label4.Visible = false;
                    label5.Visible = false;
                    pictureBox2.Visible = false;
                    textBox2.Visible = false;
                    button2.Visible = false;

                    // Doğru doğrulama kodu girildiğinde görünürlük değişiklikleri
                    label6.Visible = true;
                    label7.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    button3.Visible = true;
                }
                else
                {
                    MessageBox.Show("Doğrulama kodu yanlış");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen sayı giriniz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                string newPassword = textBox4.Text;
                for (int i = 0; i < userList.Count; i++)
                {
                    HesapOlustur.User user = (HesapOlustur.User)userList[i];
                    if (user.UserNumber == enterUser_number)
                    {
                        user.UserPassword = newPassword;
                        userList[i] = user;
                        break;
                    }
                }
                MessageBox.Show("Şifre başarıyla güncellendi.");
                GirisYap girisYap = new GirisYap(userList);
                girisYap.Show();
            }
            else
            {
                MessageBox.Show("Doğrulama Hatası!!!");
            }
        }
    }
}
