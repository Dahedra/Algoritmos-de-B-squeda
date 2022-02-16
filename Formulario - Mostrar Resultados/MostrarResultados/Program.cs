using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarResultados
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());

            do
             { 
                if (MenuPrincipal.Enteros)
                {
                    Application.Run(new Form1());

                    if (Form1.Atras)
                        Application.Run(new MenuPrincipal());
                }
                if (MenuPrincipal.Reales)
                {
                    Application.Run(new Form2());

                    if (Form2.Atras)
                        Application.Run(new MenuPrincipal());
                }
                if (MenuPrincipal.Cadenas)
                {
                    Application.Run(new Form3());

                    if (Form3.Atras)
                        Application.Run(new MenuPrincipal());
                }

            } while (!MenuPrincipal.Salir);
        }
    }
}
