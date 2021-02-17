using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio9
{

    class Selaquimorfos : Pez
    {

        public enum Subtipo
        {
            TIBURON
        }

        new Subtipo subtipo;
        int nDientes;
        string color;
        bool isDanger;
        int velocidad;

        public Selaquimorfos(string comun, string cientifico, int aletas, Medio medio, bool gragario, string localizacíon, 
            Subtipo subtipo, int nDientes, string color, bool isDanger, int velocidad)
            : base(comun, cientifico, aletas, medio, gragario, localizacíon, subtipo)
        {
            this.subtipo = subtipo;
            this.nDientes = nDientes;
            this.color = color;
            this.isDanger = isDanger;
            this.velocidad = velocidad;
        }


        public float desplazamientoDiario()
        {
            return velocidad * 24;
        }


        public override string ToString()
        {
            return base.ToString()
                + "\n\tcolor: " + this.color
                + "\n\tnDientes: " + this.nDientes
                + "\n\tisDanger: " + this.isDanger
                + "\n\tvelocidad: " + this.velocidad;
        }
    }
}
