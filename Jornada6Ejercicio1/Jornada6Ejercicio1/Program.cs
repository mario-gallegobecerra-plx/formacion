using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = System.Console.ReadLine();
            string b = System.Console.ReadLine();

            float result = new Calculate().dividir(a, b);

            Console.WriteLine(result);

            System.Threading.Thread.CurrentThread.Suspend();
        }
    }
}
