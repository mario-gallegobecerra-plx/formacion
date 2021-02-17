using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornada6Ejercicio1
{
    class Calculate
    {
        public float dividir(string a, string b)
        {
            float toRetur = -1;

            try
            {
                int aa = int.Parse(a);
                int bb = int.Parse(b);
                toRetur = float.Parse((aa / bb).ToString());
            }catch (DivideByZeroException ceroE)
            {
                System.Console.WriteLine("No se puede dividir porque el divisor es 0");
            }catch (FormatException fe)
            {
                System.Console.WriteLine("No se puede dividir porque uno o ambos números son incorrectos");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error genérico en la división");
                System.Console.WriteLine(e.Message);
            }

            return toRetur;
        }
    }
}
