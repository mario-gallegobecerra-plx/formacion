using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio7
{
    class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;
        private DateTime nacimiento;


        public Persona(string nombre, string apellidos, int edad, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.nacimiento = nacimiento;
        }


        public override string ToString()
        {
            return "\n\n\tNombre: " + this.nombre +
                "\n\tApellidos: " + this.apellidos +
                "\n\tEdad: " + this.edad +
                "\n\tNacimeinto: " + this.nacimiento.ToString("dd/MM/yyyy");
        }
    }
}
