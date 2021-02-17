using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio9
{

    class Perciformes : Pez
    {
        public enum Subtipo
        {
            LUBINA,
            DORADA,
            SARGO
        }

        new Subtipo subtipo;
        string color;

        public Perciformes(string comun, string cientifico, int aletas, Medio medio, bool gragario, Perciformes.Subtipo subtipo, string color) 
            : base(comun, cientifico, aletas, medio, gragario, "", subtipo)
        {
            this.subtipo = subtipo;
            this.color = color;

            switch (this.color.ToLower())
            {
                case "rojo":
                    base.localizacíon = "arrecife";
                    break;
                case "verde":
                    base.localizacíon = "costa";
                    break;
                case "plateado":
                    base.localizacíon = "pelágicos";
                    break;
                default :
                    base.localizacíon = "abisales";
                    break;

            }

        }

        public override string ToString()
        {
            return base.ToString()
                + "\n\tcolor: "+ this.color;
        }
    }
}
