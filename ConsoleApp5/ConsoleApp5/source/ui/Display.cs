using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.source.ui
{
    class Display
    {

        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void PrintAndWait(string msg)
        {
            Print(msg);
            Console.ReadKey();
        }


        public static void PrintList<T>(T list)
        {
            var listVar = (IEnumerable<T>)list;
            foreach (var item in listVar)
                Print(item.ToString());
        }

        public static void PrintList<T>(T[] list)
        {
            foreach (var item in list)
                Print(item.ToString());
        }

    }
}
