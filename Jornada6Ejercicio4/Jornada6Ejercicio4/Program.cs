using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            foreach (char c in s.ToCharArray())
                Console.WriteLine(c);

            System.Threading.Thread.CurrentThread.Suspend();

        }
    }
}
