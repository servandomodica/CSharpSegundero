using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto130controltimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int valor = int.Parse(label1.Text);
            valor++;
            label1.Text = valor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://picsum.photos/200";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://picsum.photos/200";
        }
    }
}
