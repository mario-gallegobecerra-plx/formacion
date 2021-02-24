using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp5.source.ui.Display;

namespace ConsoleApp5.source.ejerciciosLINQ
{
    class Ejercicio9
    {
        public static void Exec()
        {

            int[][] toWork = new int[][] {
                                new int[] {1,  2,  3,  4},
                                new int[] { 5,  6  ,7,  8 },
                                new int[] { 9,  10 ,11, 12 },
                                new int[] { 13, 14, 15 ,16 }
                            };


            var result = from res1 in toWork.Reverse()
                         select (
                            from res2 in res1.Reverse()
                            select res2
                            ).Reverse();

            foreach (var ires in result)
            {
                foreach (var jres in ires)
                    Console.Write(jres.ToString() + "\t");
                Print("\n");
            }

        }
    }
}
