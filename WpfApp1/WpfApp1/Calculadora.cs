using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    static class Calculadora
    {
        public static double totalValue = 0;

        public static void sum(double n)
        {
            totalValue += n;
        }
        public static void res(double n)
        {
            totalValue -= n;
        }
        public static void por(double n)
        {
            totalValue = totalValue * n;
        }
        public static void entre(double n)
        {
            totalValue /= n;
        }

        public static void raiz2(double n)
        {
            totalValue = Math.Sqrt(n);
        }
        public static void log10(double n)
        {
            totalValue = Math.Log10(n);
        }
    }
}
