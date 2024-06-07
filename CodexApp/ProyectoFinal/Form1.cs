using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form furmulario = new Form2();
            furmulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form furmulario = new Form4();
            furmulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form furmulario = new Form6();
            furmulario.Show();
        }
    }
}
