using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cadena
    {
        private Random rand = new Random(400); //Semila
        private string[] cadena;
        public void GenerarCadena(int cantidad)
        {
            cadena = new string[cantidad];
            for (int i = 0; i < cadena.Length; i++)
                cadena[i] = Convert.ToString(rand.Next(10000000, 99999999));
        }
        public void OrdenarCadena(string metodo)
        {
            switch (metodo)
            {
                case "buble":
                    {
                        BubleSort(cadena);
                        break;
                    }
                case "merge":
                    {
                        MergeSort(cadena, 0, cadena.Length - 1);
                        break;
                    }
                case "quick":
                    {
                        QuickSort(cadena, 0, cadena.Length - 1);
                        break;
                    }
                case "selection":
                    {
                        SelectionSort(cadena);
                        break;
                    }
            }
        }
        //METODOS DE ORDENAMIENTO
        //Buble Sort
        static private void BubleSort(string[] data)
        {
            int temp = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - 1; j++)
                {
                    if (Convert.ToInt32(data[j]) > Convert.ToInt32(data[j + 1]))
                    {
                        temp = Convert.ToInt32(data[j + 1]);
                        data[j + 1] = data[j];
                        data[j] = temp.ToString();
                    }
                }
            }
        }
        //Merge Sort
        static private void MergeSort(string[] data, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(data, left, middle);
                MergeSort(data, middle + 1, right);
                Merge(data, left, middle, right);
            }
        }
        static private void Merge(string[] data, int left, int middle, int right)
        {
            string[] leftArray = new string[middle - left + 1];
            string[] rightArray = new string[right - middle];
            Array.Copy(data, left, leftArray, 0, middle - left + 1);
            Array.Copy(data, middle + 1, rightArray, 0, right - middle);
            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    data[k] = rightArray[j].ToString();
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    data[k] = leftArray[i].ToString();
                    i++;
                }
                else if (Convert.ToInt32(leftArray[i]) <=
               Convert.ToInt32(rightArray[j]))
                {
                    data[k] = leftArray[i].ToString();
                    i++;
                }
                else
                {
                    data[k] = rightArray[j].ToString();
                    j++;
                }
            }
        }
        //Quick Sort
        private static void QuickSort(string[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = Convert.ToInt32(vector[central]);
            i = primero;
            j = ultimo;
            do
            {
                while (Convert.ToInt32(vector[i]) < pivote) i++;
                while (Convert.ToInt32(vector[j]) > pivote) j--;
                if (i <= j)
                {
                    string temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (primero < j)
            {
                QuickSort(vector, primero, j);
            }
            if (i < ultimo)
            {
                QuickSort(vector, i, ultimo);
            }
        }
        //Selection Sort
        private static void SelectionSort(string[] data)
        {
            int min;
            for (int i = 0; i < data.Length - 1; ++i)
            {
                min = i;
                for (int j = i + 1; j < data.Length; ++j)
                {
                    if (Convert.ToInt32(data[j]) < Convert.ToInt32(data[min]))
                    {
                        min = j;
                    }
                }
                int temp = Convert.ToInt32(data[min]);
                data[min] = data[i];
                data[i] = temp.ToString();
            }
        }
    }
}
