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
    public partial class Form1 : Form
    {
        static private bool atras = false;
        public Form1()
        {
            InitializeComponent();
        }
        static public bool Atras
        {
            get { return atras; }
        }
        private void CheckBox16bits_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16bits.Checked == true)
                checkBox64bits.Enabled = false;

            else if (checkBox16bits.Checked == false)
                checkBox64bits.Enabled = true;
        }

        private void CheckBox64bits_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox64bits.Checked == true)
                checkBox16bits.Enabled = false;

            else if (checkBox64bits.Checked == false)
                checkBox16bits.Enabled = true;
        }

        private void Btn_MostrarBuble_Click(object sender, EventArgs e)
        {
            if (checkBox16bits.Checked)
                MessageBox.Show("- 1.000.000 = 12:19:29:75\n- 5.000.000 = 46:27:41:93 (NO termino)\n- 8.000.000 = 47:21:53:14 (NO termino)");

            else if (checkBox64bits.Checked)
                MessageBox.Show("- 5.000.000 = 46:23:33:62");
        }

        private void Btn_MostrarMerge_Click(object sender, EventArgs e)
        {
            if (checkBox16bits.Checked)
                MessageBox.Show("- 500.000 = 00:00:00:33\n- 1.000.000 = 00:00:00:68\n- 5.000.000 = 00:00:03:16\n- 8.000.000 = 00:00:04:61");

            else if (checkBox64bits.Checked)
                MessageBox.Show("- 500.000 = 00:00:00:51\n- 1.000.000 = 00:00:00:79\n- 5.000.000 = 00:00:03:95\n- 8.000.000 = 00:00:05:89");
        }

        private void Btn_MostrarQuick_Click(object sender, EventArgs e)
        {
            if (checkBox16bits.Checked)
                MessageBox.Show("- 500.000 = 00:00:00:10\n- 1.000.000 = 00:00:00:21\n- 5.000.000 = 00:00:01:08\n- 8.000.000 = 00:00:01:78");

            else if (checkBox64bits.Checked)
                MessageBox.Show("- 500.000 = 00:00:00:23\n- 1.000.000 = 00:00:00:49\n- 5.000.000 = 00:00:03:46\n- 8.000.000 = 00:00:04:40");
        }

        private void Btn_MostrarSelection_Click(object sender, EventArgs e)
        {
            if (checkBox16bits.Checked)
                MessageBox.Show("- 1.000.000 = 00:41:49:34");

            else if (checkBox64bits.Checked)
                MessageBox.Show("- 1.000.000 = 00:50:08:15");
        }

        private void Btn_VolverAtras_Click(object sender, EventArgs e)
        {
            atras = true;
            this.Close();
        }
    }
}
