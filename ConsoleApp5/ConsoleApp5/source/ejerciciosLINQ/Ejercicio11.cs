using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp5.source.ui.Display;

namespace ConsoleApp5.source.ejerciciosLINQ
{
    class Ejercici11
    {
        public static void Exec()
        {


            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=4958002.68, Bank="CITI"}
            };

            var result = from res in customers
                         where res.Balance >= 1000000
                         group res by res.Bank into g
                         select (g);

            foreach (var resI in result)
                Print(resI.First().Bank + "\t" +resI.Count().ToString());
        }
    }

    internal class Customer
    {
        public Customer()
        {
        }

        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }

        public override string ToString()
        {
            return "\n\nbank:\t" + Bank + "\nname:\t" + Name + "\nbalance:" + Balance ;
        }
    }
}
