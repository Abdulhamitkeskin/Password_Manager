using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace user_loginSystem._0._1
{
    public partial class KullaniciSozlesmesi : Form
    {
        public KullaniciSozlesmesi()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


//---------------------------------------------------- Tasarım
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.WordWrap = true;
        }


       
    }
}
