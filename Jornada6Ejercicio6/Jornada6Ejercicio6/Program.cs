using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio6
{
    class Program
    {

        struct Punto
        {
            int y, x, z;

            public Punto(int y, int x, int z)
            {
                this.y = y;
                this.x = x;
                this.z = z;
            }

            public override string ToString()
            {
                return "\n\tx: " + x
                    + "\n\ty: " + y
                    + "\n\tz: " + z;
            }
        }

        static Random r = new Random();
        static int getRamdon()
        {
            return (int)(r.NextDouble() * 10); 
        }

        static void Main(string[] args)
        {

            Punto[] puntos = new Punto[]
            {
                new Punto(getRamdon(), getRamdon(), getRamdon()),
                new Punto(getRamdon(), getRamdon(), getRamdon()),
                new Punto(getRamdon(), getRamdon(), getRamdon()),
                new Punto(getRamdon(), getRamdon(), getRamdon()),
                new Punto(getRamdon(), getRamdon(), getRamdon()),
                new Punto(getRamdon(), getRamdon(), getRamdon()),
                new Punto(getRamdon(), getRamdon(), getRamdon()),
                new Punto(getRamdon(), getRamdon(), getRamdon()),
                new Punto(getRamdon(), getRamdon(), getRamdon()),
                new Punto(getRamdon(), getRamdon(), getRamdon())
            };


            foreach (Punto p in puntos)
                Console.WriteLine("\t=============" + p.ToString());


            System.Threading.Thread.CurrentThread.Suspend();


        }
    }
}
