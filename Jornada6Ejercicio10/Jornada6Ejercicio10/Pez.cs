using Jornada6Ejercicio10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio10
{
    class Pez : Animales
    {
        protected string comun;
        protected string cientifico;
        protected int aletas;
        protected Medio medio;
        protected bool gragario;
        protected string localizacíon;
        protected Enum subtipo;

        public Pez(string comun, string cientifico, int aletas, Medio medio, bool gragario, string localizacíon, Enum subtipo)
        {
            this.comun = comun;
            this.cientifico = cientifico;
            this.aletas = aletas;
            this.medio =  medio.Equals(Medio.MIXTO) && !(this.GetType().Name.Equals("Salmonido")) ? throw new ArgumentException("Solo los salminidos pueden ser mixtos") : medio;
            this.gragario = gragario;
            this.localizacíon = localizacíon;
            this.subtipo = subtipo;
        }

        public string Comun { get => comun; set => comun = value; }
        public string Cientifico { get => cientifico; set => cientifico = value; }
        public int Aletas { get => aletas; set => aletas = value; }
        public bool Gragario { get => gragario; set => gragario = value; }
        public string Localizacíon { get => localizacíon; set => localizacíon = value; }
        public Medio Medio { get => medio; set => medio =
                 value.Equals(Medio.MIXTO) && !(this.GetType().Name.Equals("Salmonido")) ? throw new ArgumentException("Solo los salminidos pueden ser mixtos"):value; }

        public float calcPeso(int edad, float longitud)
        {
            return (float)(edad * longitud * 20);
        }

        public void comer()
        {
            Console.WriteLine("Pez comiendo");
        }

        public void dormir()
        {
            Console.WriteLine("Pez durmiendo");
        }

        public void respirar()
        {
            Console.WriteLine("Pez respirando");
        }

        public override string ToString()
        {
            return "\n\tcomun : " + comun
                + "\n\tcientifico : " + cientifico
                + "\n\taletas : " + aletas
                + "\n\tmedio : " + medio
                + "\n\tgragario : " + gragario
                + "\n\tlocalizacíon : " + localizacíon
                + "\n\tsubtipo : " + subtipo;
        }
    }
}
