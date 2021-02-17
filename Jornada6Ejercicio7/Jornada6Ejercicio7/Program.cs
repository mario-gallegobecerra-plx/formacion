using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            int nPer = Display.menu();

            Persona[] personas = new Persona[nPer];

            for (int i = 0; i < nPer; i++)
                try
                {
                    personas[i] = Display.askPersonaData();
                }catch(Exception e)
                {
                    Console.WriteLine("Error en los datos");
                    Console.WriteLine("Codigo de error: "+ e.Message);
                    i--;
                }


            Display.showPersonasList(personas);

            System.Threading.Thread.CurrentThread.Suspend();

        }
    }
}
