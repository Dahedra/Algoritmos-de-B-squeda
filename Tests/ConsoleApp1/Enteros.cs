using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enteros
    {
        private Random rand = new Random(400); //Semilla
        private short[] shortNum;
        private long[] longNum;
        public void Generar16Bits(int cantidad)
        {
            shortNum = new short[cantidad];
            for (int i = 0; i < shortNum.Length; i++)
                shortNum[i] = (short)(rand.Next());
        }
        public void Generar64Bits(int cantidad)
        {
            longNum = new long[cantidad];
            for (int i = 0; i < longNum.Length; i++)
                longNum[i] = (long)(rand.NextDouble() * Int64.MaxValue);
        }
        public void Ordenar16Bits(string metodo)
        {
            switch (metodo)
            {
                case "buble":
                    {
                        BubleSort(shortNum);
                        break;
                    }
                case "merge":
                    {
                        MergeSort(shortNum, 0, shortNum.Length - 1);
                        break;
                    }
                case "quick":
                    {
                        QuickSort(shortNum, 0, shortNum.Length - 1);
                        break;
                    }
                case "selection":
                    {
                        SelectionSort(shortNum);
                        break;
                    }
            }
        }
        public void Ordenar64Bits(string metodo)
        {
            switch (metodo)
            {
                case "buble":
                    {
                        BubleSort(longNum);
                        break;
                    }
                case "merge":
                    {
                        MergeSort(longNum, 0, longNum.Length - 1);
                        break;
                    }
                case "quick":
                    {
                        QuickSort(longNum, 0, shortNum.Length - 1);
                        break;
                    }
                case "selection":
                    {
                        SelectionSort(longNum);
                        break;
                    }
            }
        }
        //METODOS DE ORDENAMIENTO
        //Buble Sort
        static private void BubleSort(short[] data)
        {
            short temp = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        } //Short
        static private void BubleSort(long[] data)
        {
            long temp = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        } //Long
          //Merge Sort
        static private void MergeSort(short[] data, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(data, left, middle);
                MergeSort(data, middle + 1, right);
                Merge(data, left, middle, right);
            }
        } //Short
        static private void Merge(short[] data, int left, int middle, int right)
        {
            short[] leftArray = new short[middle - left + 1];
            short[] rightArray = new short[right - middle];
            Array.Copy(data, left, leftArray, 0, middle - left + 1);
            Array.Copy(data, middle + 1, rightArray, 0, right - middle);
            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    data[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    data[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    data[k] = leftArray[i];
                    i++;
                }
                else
                {
                    data[k] = rightArray[j];
                    j++;
                }
            }
        } //Short
        static private void MergeSort(long[] data, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(data, left, middle);
                MergeSort(data, middle + 1, right);
                Merge(data, left, middle, right);
            }
        } //Long
        static private void Merge(long[] data, int left, int middle, int right)
        {
            long[] leftArray = new long[middle - left + 1];
            long[] rightArray = new long[right - middle];
            Array.Copy(data, left, leftArray, 0, middle - left + 1);
            Array.Copy(data, middle + 1, rightArray, 0, right - middle);
            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    data[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    data[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    data[k] = leftArray[i];
                    i++;
                }
                else
                {
                    data[k] = rightArray[j];
                    j++;
                }
            }
        } //Long
          //Quick Sort
        private static void QuickSort(short[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    short temp;
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
        } //Short
        private static void QuickSort(long[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    long temp;
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
        } //Long
          //Selection Sort
        private static void SelectionSort(short[] data)
        {
            int min;
            for (int i = 0; i < data.Length - 1; ++i)
            {
                min = i;
                for (int j = i + 1; j < data.Length; ++j)
                {
                    if (data[j] < data[min])
                    {
                        min = j;
                    }
                }
                short temp = data[min];
                data[min] = data[i];
                data[i] = temp;
            }
        } //Short
        private static void SelectionSort(long[] data)
        {
            int min;
            for (int i = 0; i < data.Length - 1; ++i)
            {
                min = i;
                for (int j = i + 1; j < data.Length; ++j)
                {
                    if (data[j] < data[min])
                    {
                        min = j;
                    }
                }
                long temp = data[min];
                data[min] = data[i];
                data[i] = temp;
            }
        } //Long
    }
}
