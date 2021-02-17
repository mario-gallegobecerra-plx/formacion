using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehiculo v1 = new Vehiculo();
            Vehiculo v2 = new Vehiculo(null, "Fiesta", 10000, Combustible.GASOLINA); 

            v1.Marca = "Citroen";
            v1.Combustible = Combustible.ELECTRICO;

            Console.WriteLine(v1.ToString());
            Console.WriteLine("Edad matriculado en 11/11/2011 \t" + v1.calcAge("11/11/2011") + "años");

            Console.WriteLine("\n ==================== \n");
            Console.WriteLine(v2);


            System.Threading.Thread.CurrentThread.Suspend();

        }
    }
}
