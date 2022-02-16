using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            Enteros enteros = new Enteros();
            Reales reales = new Reales();
            Cadena cadena = new Cadena();
            TimeSpan finalizadoen;
            //Aca se llama para generar el arreglo
            //EJ:
            //reales.Generar32Bits(1000000);
            DateTime inicio = DateTime.Now;
            //Aca va el metodo
            //Ej:
            //cadena.OrdenarCadena("selection");
            DateTime fin = DateTime.Now;
            finalizadoen = fin - inicio;
            int hora = finalizadoen.Days * 24;
            int minutos = finalizadoen.Minutes;
            int segundos = finalizadoen.Seconds;
            int milisegundos = finalizadoen.Milliseconds;
            Console.WriteLine(" finalizado, el tiempo es {0} horas {1} minutos {2} segundos { 3} milisegundos", hora, minutos, segundos, milisegundos);
            Console.ReadKey();

        }
    }
}
