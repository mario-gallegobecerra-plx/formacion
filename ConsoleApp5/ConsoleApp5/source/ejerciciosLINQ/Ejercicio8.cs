using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp5.source.ui.Display;

namespace ConsoleApp5.source.ejerciciosLINQ
{
    class Ejercicio8
    {
        public static void Exec()
        {

            char[] toWork1 = new char[] { 'A', 'B', 'C' };
            int[] toWork2 = new int[] { 1,2,3};


            var result = from res1 in toWork1
                         join res2 in toWork2
                         on 1 equals 1
                         select (object)(res1 +","+ res2);

            PrintList((object)result);

        }
    }
}
