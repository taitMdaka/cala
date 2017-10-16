using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public partial class cala : Form
    {
        public cala()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            mathmatho mathmatho = new mathmatho();
            textBox2.Text = mathmatho.square(x).ToString();

            //  ma = new mathmatho();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
