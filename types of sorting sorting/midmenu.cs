using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types_of_sorting_sorting
{
    public class menu
    {
        Array massiv = new Array(); 
        private const int Size_midle_menu = 6;//размер основного меню 
        private const int Size_sort_menu = 1;//размер меню сортировки

        public void menuAll(ref bool flag)
        {
            midle_menu();
            flag =logik_midle_menu();
            Console.WriteLine("нажмити  Enter для подолжения");
            Console.ReadKey();
            Console.Clear();
        }
        static public void midle_menu ()
        {
            Console.WriteLine(" _________________________________");
            Console.WriteLine("|1 добавить новый элемент в массив|");
            Console.WriteLine("|2 загрузить массив из файла      |");
            Console.WriteLine("|3 вывести массив                 |");
            Console.WriteLine("|4 отсортировать массив           |");
            Console.WriteLine("|5 удалить массив                 |");
            Console.WriteLine("|6 выход                          |");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("Введите значение:");
        }

        public bool logik_midle_menu()
        {
            int veleu = checkdurak.CheckSetVeleu(Size_midle_menu);
            switch (veleu)
            {
                case 1:
                    {
                        Console.WriteLine("Введите значение:");
                        massiv.ArrayList.AddRange(checkdurak.CheckSetVeleu());
                        break;
                    }
                case 2:
                    {
                        massiv.Upload();
                        break;
                    }
                case 3:
                    {
                        massiv.Print();
                        break;
                    }
                case 4:
                    {
                        massiv.BubbleSort();
                        break;
                    }
                case 5:
                    {
                        massiv.ArrayList.Clear();
                        break;
                    }
                case 6:
                    {
                        return false;
                    }

            }
            return true;
        }

        static void sort_menu()
        {
            Console.WriteLine(" ________________________________________");
            Console.WriteLine("|1 сортировка пузырьком (BubbleSort)     |");
            Console.WriteLine("|________________________________________|");
            Console.WriteLine("Введите значение:");
        }

        public bool logik_sort_menu()
        {
            int veleu = checkdurak.CheckSetVeleu(Size_sort_menu);
            switch (veleu)
            {
                case 1:
                    {
                        massiv.ArrayList.Sort();
                        break;
                    }
                case 2:
                    {
                        massiv.BubbleSort();
                        break;
                    }
                

            }
            return true;
        }

    }
}
