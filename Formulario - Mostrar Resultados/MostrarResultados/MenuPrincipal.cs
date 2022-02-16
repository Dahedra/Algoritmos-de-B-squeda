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
    public partial class MenuPrincipal : Form
    {
        static private bool salir = false;
        static private bool entero = false;
        static private bool reales = false;
        static private bool cadena = false;
        static public bool Enteros
        {
            get { return entero; }
        }
        static public bool Reales
        {
            get { return reales; }
        }
        static public bool Cadenas
        {
            get { return cadena; }
        }
        static public bool Salir
        {
            get { return salir; }
        }
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Enteros_Click(object sender, EventArgs e)
        {
            entero = true;
            this.Close();
        }

        private void Btn_Reales_Click(object sender, EventArgs e)
        {
            reales = true;
            this.Close();
        }

        private void Btn_Cadenas_Click(object sender, EventArgs e)
        {
            cadena = true;
            this.Close();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            salir = true;
            this.Close();
        }
    }
}
