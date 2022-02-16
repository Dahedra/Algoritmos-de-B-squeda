using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Reales
    {
        private Random rand = new Random(400); //Semila
        private float[] floatNum;
        private decimal[] decimalNum;
        public void Generar32Bits(int cantidad)
        {
            floatNum = new float[cantidad];
            for (int i = 0; i < floatNum.Length; i++)
                floatNum[i] = Convert.ToSingle(rand.NextDouble());
        }
        public void Generar128Bits(int cantidad)
        {
            decimalNum = new decimal[cantidad];
            for (int i = 0; i < decimalNum.Length; i++)
                decimalNum[i] = Convert.ToDecimal(rand.NextDouble());
        }
        public void Ordenar32Bits(string metodo)
        {
            switch (metodo)
            {
                case "buble":
                    {
                        BubleSort(floatNum);
                        break;
                    }
                case "merge":
                    {
                        MergeSort(floatNum, 0, floatNum.Length - 1);
                        break;
                    }
                case "quick":
                    {
                        QuickSort(floatNum, 0, floatNum.Length - 1);
                        break;
                    }
                case "selection":
                    {
                        SelectionSort(floatNum);
                        break;
                    }
            }
        }
        public void Ordenar128Bits(string metodo)
        {
            switch (metodo)
            {
                case "buble":
                    {
                        BubleSort(decimalNum);
                        break;
                    }
                case "merge":
                    {
                        MergeSort(decimalNum, 0, decimalNum.Length - 1);
                        break;
                    }
                case "quick":
                    {
                        QuickSort(decimalNum, 0, decimalNum.Length - 1);
                        break;
                    }
                case "selection":
                    {
                        SelectionSort(decimalNum);
                        break;
                    }
            }
        }
        //METODOS DE ORDENAMIENTO
        //Buble Sort
        static private void BubleSort(float[] data)
        {
            float temp = 0;
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
        } //Float
        static private void BubleSort(decimal[] data)
        {
            decimal temp = 0;
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
        } //Decimal
          //Merge Sort
        static private void MergeSort(float[] data, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(data, left, middle);
                MergeSort(data, middle + 1, right);
                Merge(data, left, middle, right);
            }
        } //Float
        static private void Merge(float[] data, int left, int middle, int right)
        {
            float[] leftArray = new float[middle - left + 1];
            float[] rightArray = new float[right - middle];
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
        } //Float
        static private void MergeSort(decimal[] data, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(data, left, middle);
                MergeSort(data, middle + 1, right);
                Merge(data, left, middle, right);
            }
        } //Decimal
        static private void Merge(decimal[] data, int left, int middle, int right)
        {
            decimal[] leftArray = new decimal[middle - left + 1];
            decimal[] rightArray = new decimal[right - middle];
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
        } //Decimal
          //Quick Sort
        private static void QuickSort(float[] vector, int primero, int ultimo)
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
                    float temp;
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
        } //Float
        private static void QuickSort(decimal[] vector, int primero, int ultimo)
        {
            int i, j, central;
            decimal pivote;
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
                    decimal temp;
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
        } //Decimal
          //Selection Sort
        private static void SelectionSort(float[] data)
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
                float temp = data[min];
                data[min] = data[i];
                data[i] = temp;
            }
        } //Float
        private static void SelectionSort(decimal[] data)
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
                decimal temp = data[min];
                data[min] = data[i];
                data[i] = temp;
            }
        } //Decimal
    }
}
