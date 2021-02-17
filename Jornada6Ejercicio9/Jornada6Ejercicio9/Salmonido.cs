using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio9
{


    class Salmonido : Pez
    {

        public enum Subtipo
        {
            TRUCHA, SALMON, REO
        }

        new Subtipo subtipo;


        // Constructors
        public Salmonido(string comun, string cientifico, int aletas, Medio medio, bool gragario, string localizacíon, Salmonido.Subtipo subtipo)
            : base(comun, cientifico, aletas, medio, gragario, localizacíon, subtipo)
        {
            this.subtipo = subtipo;
        }


        // Methods
        private new float calcPeso(int edad, float longitud)
        {
            return longitud * 10;
        }
        public float calcPeso(float longitud)
        {
            return calcPeso(0, longitud);
        }
    }
}
