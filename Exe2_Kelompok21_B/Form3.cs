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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.Kasir' table. You can move, or remove it, as needed.
            this.kasirTableAdapter.Fill(this.supermarketDataSet.Kasir);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
