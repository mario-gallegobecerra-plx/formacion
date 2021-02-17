using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio2
{
    class Program
    {

        public static bool isPar(int a)
        {
            return a % 2 == 0;
        }

        static void Main(string[] args)
        {
            try
            {
                string s = Console.ReadLine();
                int sa = int.Parse(s);

                Console.WriteLine(isPar(sa) ? "es par" : "no es par");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

            System.Threading.Thread.CurrentThread.Suspend();


        }
    }
}
