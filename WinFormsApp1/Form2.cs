using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public static string namaUser = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && maskedTextBox1.Text == "password")
            {
                namaUser = "admin";
                Form1 F1 = new Form1();
                F1.Show();
                this.Hide();
            }else if (textBox1.Text == "user" && maskedTextBox1.Text == "password")
            {
                namaUser = "user";
                Form1 F1 = new Form1();
                F1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kredensial salah!");
            }
        }
    }
}
