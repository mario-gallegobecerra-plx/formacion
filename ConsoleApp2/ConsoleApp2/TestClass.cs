using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TestClass
    {

     // Class vars
        private string outVar;


     // Constructors
        public TestClass()
        { }
        public TestClass(string outVar)
        {
            this.outVar = outVar;
            outMsg();
        }


     // Methods
        public void outMsg()
        {
            System.Console.WriteLine(this.outVar);
        }

        public void hola()
        {
            System.Console.WriteLine("hola");
        }
    }
}
