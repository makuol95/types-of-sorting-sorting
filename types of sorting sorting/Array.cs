using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types_of_sorting_sorting
{
    public class Array
    {
        public List<int> ArrayList = new List<int>();
        private readonly string path = @"C:\Users\lord-\Desktop\project\portfolio\types of sorting sorting\types-of-sorting-sorting\types of sorting sorting\bin\Debug\net5.0\array.txt";
        //строка подключения 
        public void Upload()
        {
            Console.WriteLine("добавленые элменты:");
            foreach (var a in File.ReadAllText(path).Split(' '))
            {
                ArrayList.Add(Int32.Parse(a));
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        public void Print()
        {
            if (ArrayList.Count > 0|| ArrayList==null)
                Console.WriteLine(string.Join(' ', ArrayList));
            else
                Console.WriteLine("Массив пустой добавте элементов");
        }

        private int[] ListINArray()
        {
            int[] arr = new int[ArrayList.Count];
            ArrayList.CopyTo(arr);
            return arr;
        }

        private void ArrayInList(int[] arr)
        {
            ArrayList = new List<int>(arr);
        }
        public void BubbleSort()
        {
            int[] array = ListINArray();
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        int t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
            ArrayInList(array);
        }
    }
}
