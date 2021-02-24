using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp5.source.ui.Display;

namespace ConsoleApp5.source.ejerciciosLINQ
{
    class Ejercicio1
    {

        public static void Exec()
        {

            int[] toWork = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Object result = from res in toWork
                            where res % 2 == 0
                             select ((object)res) ;

            PrintList(result);
            
        }

    }
}
