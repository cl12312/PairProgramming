using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformControlUse
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:/Users/chen123/Desktop/材料/timg.gif");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Random rd = new Random();
            int i = rd.Next(0, 5);
            pictureBox1.Image = imageList1.Images[i];
        }
    }
}
