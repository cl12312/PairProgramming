using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinformControlUse;


namespace WiControl
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string password = this.textBox2.Text;
            if(name.Equals("admin") && password .Equals ("123"))
            {
                MessageBox.Show("登录成功");
                this.Hide();
                welcome w = new welcome();
                w.Show();

            }
            else
            {
                MessageBox.Show("密码或账号错误！");
                this.textBox1.Clear();
                this.textBox2.Clear();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }
    }
}
