using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarResultados
{
    public partial class Form3 : Form
    {
        static private bool atras = false;
        public Form3()
        {
            InitializeComponent();
        }
        static public bool Atras
        {
            get { return atras; }
        }

        private void Btn_MostrarBuble_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- 500.000 = 16:03:23:45 (NO terminó)");
        }

        private void Btn_MostrarMerge_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- 500.000 =  00:00:02:57\n- 1.000.000 = 00:00:05:42\n- 5.000.000 = 00:00:31:30\n- 8.000.000 = 00:00:51:91");
        }

        private void Btn_MostrarQuick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- 500.000 =  00:00:02:05\n- 1.000.000 = 00:00:04:42\n- 5.000.000 = 00:00:24:78\n- 8.000.000 = 00:00:40:75");
        }

        private void Btn_MostrarSelection_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- 5.000.000 = 13:08:42:71 (NO terminó)");
        }

        private void Btn_VolverAtras_Click(object sender, EventArgs e)
        {
            atras = true;
            this.Close();
        }
    }
}
