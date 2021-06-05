using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types_of_sorting_sorting
{
    class checkdurak
    {
        static public int CheckSetVeleu(int linght)
        {
            bool flag = true;
            int rezult=0;
            while (flag)
            {               
                try
                {
                    rezult = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {                    
                    Console.WriteLine("Неверное значение!!!!");
                }
                if (rezult > 0 && rezult <= linght)
                    flag = false;
                else
                    Console.WriteLine("Ввидите значения от 1 до {0}:", linght);
            }

            return rezult;
        }

        static public List<int> CheckSetVeleu()
        {
            bool flag = true;
            List<int> rezult = new List<int>();
            while (flag)
            {
                string elementary;
                elementary = Console.ReadLine();
                try
                {
                    foreach (var a in elementary.Split(' '))
                    {
                        rezult.Add(Int32.Parse(a));                        
                    }
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Неверное значение!!!!");
                }                
            }

            return rezult;
        }
    }
}
