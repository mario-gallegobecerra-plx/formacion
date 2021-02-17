    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string s = Console.ReadLine();
                int a = int.Parse(s);

                switch (a)
                {
                    case (int)Meses.Enero:
                        Console.WriteLine(Meses.Enero);
                        break;
                    case (int)Meses.Febrero:
                        Console.WriteLine(Meses.Febrero);
                        break;
                    case (int)Meses.Marzo:
                        Console.WriteLine(Meses.Marzo);
                        break;
                    case (int)Meses.Abril:
                        Console.WriteLine(Meses.Abril);
                        break;
                    case (int)Meses.Mayo:
                        Console.WriteLine(Meses.Mayo);
                        break;
                    case (int)Meses.Junio:
                        Console.WriteLine(Meses.Junio);
                        break;
                    case (int)Meses.Julio:
                        Console.WriteLine(Meses.Julio);
                        break;
                    case (int)Meses.Agosto:
                        Console.WriteLine(Meses.Agosto);
                        break;
                    case (int)Meses.Septiembre:
                        Console.WriteLine(Meses.Septiembre);
                        break;
                    case (int)Meses.Octubre:
                        Console.WriteLine(Meses.Octubre);
                        break;
                    case (int)Meses.Noviembre:
                        Console.WriteLine(Meses.Noviembre);
                        break;
                    case (int)Meses.Diciembre:
                        Console.WriteLine(Meses.Diciembre);
                        break;
                    default:
                        Console.WriteLine("404 mes not found");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            System.Threading.Thread.CurrentThread.Suspend();

        }
    }
}
