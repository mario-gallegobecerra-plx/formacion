using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp5.source.ui.Display;

namespace ConsoleApp5.source.ejerciciosLINQ
{
    class Ejercicio7
    {
        public static void Exec()
        {

            char[] toWork = new char[] {'M','O','P','A' };

            PrintList(toWork);
            Print("................");
            char recived = ((char)Console.Read());

            var result = from res in toWork
                         where !res.ToString().ToLower().Equals(recived.ToString().ToLower())
                         select ((object)res);
            Print("................");

            PrintList((object)result);

        }
    }
}
