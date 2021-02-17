using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio7
{
    class Display
    {

        public static int menu()
        {
            int toReturn = -1;
            bool flagNValido = false;

            do
            {
                Console.WriteLine("Introduce el número de personas a añadir");
                string s = Console.ReadLine();
                try
                {
                    toReturn = int.Parse(s);
                }catch(Exception e)
                {
                    Console.WriteLine("Numero invalido\n");
                }
                if (toReturn > 0)
                    return toReturn;

                Console.WriteLine("El número debe ser mayor que 0\n");

            } while (!flagNValido);

            return toReturn;
        }


        public static Persona askPersonaData()
        {
            string nombre;
            string apellidos;
            int edad;
            DateTime nacimiento;

            Console.WriteLine("\n Introduce el nombre de la persona");
            nombre = Console.ReadLine();

            Console.WriteLine("\n Introduce los apellidos de la persona");
            apellidos = Console.ReadLine();

            Console.WriteLine("\n Introduce la edad de la persona");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Introduce la fecha de nacimiento con formato dd/MM/aaaa");
            nacimiento = DateTime.Parse(Console.ReadLine());

            return new Persona(nombre, apellidos, edad, nacimiento);
        }


        public static void showPersonasList(Persona[] personas)
        {

            Queue<Persona> personasQueu = new Queue<Persona>(personas);


            Console.WriteLine("\n\n Queu FIFO");
            foreach (Persona p in personasQueu)
                Console.WriteLine(p.ToString());


            Console.WriteLine("\n\n Queu LIFO");
            for (int i = personasQueu.Count; i>0;i--)
                Console.WriteLine(personas[i-1].ToString());
        }


    }
}
