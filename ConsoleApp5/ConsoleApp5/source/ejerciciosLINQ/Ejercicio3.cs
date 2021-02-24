using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp5.source.ui.Display;

namespace ConsoleApp5.source.ejerciciosLINQ
{
    class Ejercicio3
    {
        public static void Exec()
        {

            int[] toWork = new int[] { 3, 9, 2, 8, 6, 5 };

            Object result = from res in toWork
                            where 1 == 1
                            select (object)(res +"\t"+ res*res);

            PrintList(result);
        }
    }
}
