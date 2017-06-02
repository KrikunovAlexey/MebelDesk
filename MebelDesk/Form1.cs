using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MebelDesk
{
    public partial class Form1 : Form
    {
        Kitchen k;
        public Form1()
        {
            InitializeComponent();
            k = new Kitchen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sh = Convert.ToInt32(comboBox1.SelectedItem);
            int ots = Convert.ToInt32(textBox1.Text);
            int dver = comboBox2.SelectedIndex;
            int kol_dver = comboBox3.SelectedIndex;
            int height = Convert.ToInt32(textBox2.Text);
            int pol = comboBox4.SelectedIndex;
            int kol_pol = Convert.ToInt32(textBox3.Text);
            k.add(sh, ots, dver, kol_dver, height, pol, kol_pol);
            k.show();
        }
    }
}
