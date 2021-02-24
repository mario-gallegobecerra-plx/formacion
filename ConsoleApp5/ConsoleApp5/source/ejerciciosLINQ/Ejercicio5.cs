using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp5.source.ui.Display;

namespace ConsoleApp5.source.ejerciciosLINQ
{
    class Ejercicio5
    {
        public static void Exec()
        {

            string[] toWork = new string[] { "ROMA", "LONDRES", "ZARAGOZA", "A CORUÑA", "ZURICH", "BERLIN", "AMSTERDAM", "AMBERES", "PARIS" };

            var result = from res in toWork
                         where res.StartsWith("A") && res.EndsWith("M")
                         select (object)(res);

            PrintList((object)result);
        }
    }
}
