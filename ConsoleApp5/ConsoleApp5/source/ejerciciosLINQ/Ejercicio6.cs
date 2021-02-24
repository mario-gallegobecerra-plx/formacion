using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp5.source.ui.Display;

namespace ConsoleApp5.source.ejerciciosLINQ
{
    class Ejercicio6
    {
        public static void Exec()
        {

            int[] toWork = new int[] { 5, 7, 13, 9, 55, 4, 16 };

            int recived = int.Parse(Console.ReadLine());

            var result = from res in toWork
                         where 1 == 1
                         orderby res descending
                         select (object)(res);

            result = result.Take(recived);

            PrintList((object)result);
        }
    }
}
