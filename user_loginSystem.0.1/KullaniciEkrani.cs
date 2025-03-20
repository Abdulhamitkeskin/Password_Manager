using System;
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
    public partial class KullaniciEkrani : Form
    {
        private string userName, userNumber, userPassword, userGender,userSecret;

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
        }

        public KullaniciEkrani(String userName ,String userNumber ,String userPassword,String userGender,String userSecret)
        {
            InitializeComponent();

            this.userName = userName;
            this.userNumber = userNumber;
            this.userPassword = userPassword;
            this.userGender = userGender;
            this.userSecret = userSecret;

            if (userGender == "Erkek")
            {
                pictureBox2.Visible = false;
                this.BackColor = Color.Silver;

            }
            if(userGender == "Kadın")
            {
                pictureBox1.Visible = false;
                this.BackColor = Color.Pink;
            }

            label1.Text = userName;
            label2.Text = userPassword;
            label3.Text = userNumber;
            textBox1.Text = userSecret;

        }

      

       

        
    }
}
