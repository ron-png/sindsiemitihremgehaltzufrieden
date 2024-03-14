using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Wirklich?";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Location = new System.Drawing.Point(rnd.Next(0, 700), rnd.Next(0, 300));
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Location = new System.Drawing.Point(rnd.Next(0, 700), rnd.Next(0, 300));
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            button2.Location = new System.Drawing.Point(rnd.Next(0, 700), rnd.Next(0, 300));
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Location = new System.Drawing.Point(rnd.Next(0, 700), rnd.Next(0, 300));
        }
    }
}
