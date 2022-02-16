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
    public partial class Form2 : Form
    {
        static private bool atras = false;
        public Form2()
        {
            InitializeComponent();
        }
        static public bool Atras
        {
            get { return atras; }
        }
        private void CheckBox16bits_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32bits.Checked == true)
                checkBox128bits.Enabled = false;

            else if (checkBox32bits.Checked == false)
                checkBox128bits.Enabled = true;
        }

        private void CheckBox64bits_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox128bits.Checked == true)
                checkBox32bits.Enabled = false;

            else if (checkBox128bits.Checked == false)
                checkBox32bits.Enabled = true;
        }

        private void Btn_MostrarBuble_Click(object sender, EventArgs e)
        {
            if (checkBox32bits.Checked)
                MessageBox.Show("NADA AÚN");

            else if (checkBox128bits.Checked)
                MessageBox.Show("NADA AÚN");
        }

        private void Btn_MostrarMerge_Click(object sender, EventArgs e)
        {
            if (checkBox32bits.Checked)
                MessageBox.Show("- 500.000 = 00:00:00:45\n- 1.000.000 = 00:00:01:02\n- 5.000.000 = 00:00:04:30\n- 8.000.000 = 00:00:06:13");

            else if (checkBox128bits.Checked)
                MessageBox.Show("- 500.000 = 00:00:00:94\n- 1.000.000 = 00:00:02:56\n- 5.000.000 = 00:00:08:20\n- 8.000.000 = 00:00:12:58");
        }

        private void Btn_MostrarQuick_Click(object sender, EventArgs e)
        {
            if (checkBox32bits.Checked)
                MessageBox.Show("- 500.000 =  00:00:00:10\n- 1.000.000 = 00:00:00:21\n- 5.000.000 = 00:00:01:15\n- 8.000.000 = 00:00:01:85");

            else if (checkBox128bits.Checked)
                MessageBox.Show("- 500.000 = 00:00:00:42\n- 1.000.000 = 00:00:00:88\n- 5.000.000 = 00:00:04:71\n- 8.000.000 = 00:00:07:60");
        }

        private void Btn_MostrarSelection_Click(object sender, EventArgs e)
        {
            if (checkBox32bits.Checked)
                MessageBox.Show("NADA AÚN");

            else if (checkBox128bits.Checked)
                MessageBox.Show("NADA AÚN");
        }

        private void Btn_VolverAtras_Click(object sender, EventArgs e)
        {
            atras = true;
            this.Close();
        }
    }
}
