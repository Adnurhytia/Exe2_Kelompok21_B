using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2_Kelompok21_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myForm2= new Form2();
            myForm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 myForm3= new Form3();
            myForm3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
