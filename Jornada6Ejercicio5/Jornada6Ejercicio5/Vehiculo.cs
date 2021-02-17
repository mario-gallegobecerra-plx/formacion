using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio5
{
    class Vehiculo
    {
        // Attributes
        private string marca;
        private string modelo;
        private Int64 kilometros;
        private Combustible combustible;


        // Constructos
        public Vehiculo()
        {
            this.kilometros = 0;
            this.Combustible = Combustible.NO_ESPECIFICADO;
        }

        public Vehiculo(string marca, string modelo, int kilometros, Combustible combustible)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Kilometros = kilometros;
            this.Combustible = combustible;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public Int64 Kilometros { get => kilometros; set => kilometros = value; }
        public Combustible Combustible { get => combustible; set => combustible = value; }


        // Methods
        public int calcAge(string date)
        {
            int toRetur = -1;
            try
            {
                DateTime currentDate = DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy"));
                DateTime marticDate = DateTime.Parse(date);

                int years = (int)((currentDate - marticDate).Days / 365);
                toRetur = years;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

                
            if (toRetur < 0)
                throw new Exception("Fecha invalida");


            return toRetur;
        }


        public override string ToString()
        {
            if (this.marca == null)
                this.marca = "Valor no especificado";
            if (this.modelo == null)
                this.modelo = "Valor no especificado";

            return "Marca : " + this.marca + "\n"
                    + "Modelo : " + this.modelo + "\n"
                    + "Kilometros : " + this.kilometros + "\n"
                    + "Combustible : " + this.Combustible;
        }

    }
}
