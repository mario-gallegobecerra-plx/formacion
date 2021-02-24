using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp5.source.ui.Display;

namespace ConsoleApp5.source.ejerciciosLINQ
{
    class Ejercicio2
    {

        public static void Exec()
        {
            int[] toWork = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            Object result = from res in toWork
                            where res < 12 && res > 1
                            select (object)res;

            PrintList(result);
        }

    }
}
