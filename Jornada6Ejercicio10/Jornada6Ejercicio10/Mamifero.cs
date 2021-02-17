using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio10
{
    class Mamifero : Animales
    {
        public Mamifero()
        {
        }

        public void comer()
        {
            Console.WriteLine("Mamifero comiendo");
        }

        public void dormir()
        {
            Console.WriteLine("Mamifero durmiendo");
        }

        public void respirar()
        {
            Console.WriteLine("Mamifero respirando");
        }
    }
}
