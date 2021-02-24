using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp5.source.ui.Display;

namespace ConsoleApp5.source.ejerciciosLINQ
{
    class Ejercicio4
    {
        public static void Exec()
        {

            int[] toWork = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2};

            var result = from res in toWork
                         where 1 == 1
                            group res by res into g
                            orderby g.Key ascending
                            select (object)(g.Key + "\t"+ g.Count());

            PrintList((object)result);
        }
    }
}
