using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Pez p1 = new Salmonido("salmon", "solmonelosus", 4, Medio.MIXTO, true, "aquí", Salmonido.Subtipo.REO);
            Pez p2 = new Perciformes("qwer", "test", 4, Medio.MARINO, true, Perciformes.Subtipo.LUBINA, "Rojo");
            Pez p3 = new Selaquimorfos("testee", "asdf", 4, Medio.FLUVIAL, true, "allí", Selaquimorfos.Subtipo.TIBURON, 8, "Azul", true, 10);

            Console.WriteLine(p1);
            Salmonido sa1 = (Salmonido)p1;
            Console.WriteLine(sa1.calcPeso(10));

            Console.WriteLine(p2);

            Console.WriteLine(p3);
            Selaquimorfos se1 = (Selaquimorfos) p3;
            Console.WriteLine(se1.desplazamientoDiario());


            System.Threading.Thread.CurrentThread.Suspend();

        }
    }
}
