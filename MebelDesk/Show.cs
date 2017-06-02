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
    public partial class Show : Form
    {
        public Show(Stol_dveri sd)
        {
            InitializeComponent();
            label1.Text = sd.stoika.getX();
            label2.Text = sd.stoika.getY();
            label3.Text = sd.stoika.getKol();
            label4.Text = sd.dnishe.getX();
            label5.Text = sd.dnishe.getY();
            label6.Text = sd.dnishe.getKol();
            label7.Text = sd.carga.getX();
            label8.Text = sd.carga.getY();
            label9.Text = sd.carga.getKol();
            label10.Text = sd.polka.getX();
            label11.Text = sd.polka.getY();
            label12.Text = sd.polka.getKol();
            label13.Text = sd.dveri.getX();
            label14.Text = sd.dveri.getY();
            label15.Text = sd.dveri.getKol();
        }
    }
}
