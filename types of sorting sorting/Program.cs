using System;
using System.Collections.Generic;

namespace types_of_sorting_sorting
{

    class Program
    {

        static void Main(string[] args)
        {
            bool flag = true;
            menu Mn = new menu();
            while (flag)
            {
                Mn.menuAll(ref flag);
            }



        }
    }
}
