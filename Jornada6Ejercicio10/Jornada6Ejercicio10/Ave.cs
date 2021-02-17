using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio10
{
    class Ave : Animales
    {
        public Ave()
        {
        }

        public void comer()
        {
            Console.WriteLine("Ave comiendo");
        }

        public void dormir()
        {
            Console.WriteLine("Ave durmiendo");
        }

        public void respirar()
        {
            Console.WriteLine("Ave respirar");
        }
    }
}
