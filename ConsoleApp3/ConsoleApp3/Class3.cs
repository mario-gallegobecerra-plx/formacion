using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class3 : Class1, Class2, Interface1
    {

        new string padre = "hija";

        public void printBase()
        {
            System.Console.WriteLine(this.showBase());
        }

        public string showBase()
        {
            return this.padre;
        }
    }
}
