using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {

        static void ejercicio4()
        {
            System.Console.WriteLine(-1 + 4 * 6);
            System.Console.WriteLine((35 + 5) % 7);
            System.Console.WriteLine(14 + -4 * 6 / 11);
            System.Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }

        static void ejercicio5()
        {
            int int1 = int.Parse(System.Console.ReadLine());

            int int2 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("first number " + (int1.ToString()));
            System.Console.WriteLine("Second number " + (int2.ToString()));
        }

        static void ejercicio6()
        {

            int int1 = int.Parse(System.Console.ReadLine());

            int int2 = int.Parse(System.Console.ReadLine());

            int int3 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(int1 * int2 * int3);
        }


        static void ejercicio7()
        {
            int a = int.Parse(System.Console.ReadLine());
            int b = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(a + b);
            System.Console.WriteLine(a - b);
            System.Console.WriteLine(a * b);
            System.Console.WriteLine(a / b);

        }

        static void ejercicio8()
        {
            int a = int.Parse(System.Console.ReadLine());

            for (int i = 0; i <= 20; i++)
                System.Console.WriteLine(a * i);

        }


        static void ejercicio9()
        {
            int a = int.Parse(System.Console.ReadLine());
            int b = int.Parse(System.Console.ReadLine());
            int c = int.Parse(System.Console.ReadLine());
            int d = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine((a + b + c + d) / 4);


        }

        static void ejercicio10()
        {
            int a = int.Parse(System.Console.ReadLine());
            int b = int.Parse(System.Console.ReadLine());
            int c = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine((a + b) * c);
            System.Console.WriteLine(a * b + b * c);

        }

        static void ejercicio11()
        {
            int a = int.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine("you look older that" +  a);
        }


        static void ejercicio12()
        {
            int a = int.Parse(System.Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                string toPrint = a.ToString();

                if (i % 2 == 0)
                    toPrint = toPrint + " ";
                System.Console.Write(toPrint + toPrint + toPrint + toPrint);
            }
        }


        static void ejercicio13()
        {
            int a = int.Parse(System.Console.ReadLine());

            System.Console.Write(a + a + a);
            for (int i = 0; i < 3; i++)
                System.Console.Write(a + "  " + a);
            System.Console.Write(a + a + a);
        }


        static void ejercicio14()
        {
            int a = int.Parse(System.Console.ReadLine());

            System.Console.Write(a + 273.15);
            System.Console.Write((a * 9 / 5) + 32);

        }

        static void ejercicio15()
        {
            string a = System.Console.ReadLine();

            Random r = new Random();

            for (int i = 0; i < 3; i++)
                System.Console.WriteLine(a.Remove(r.Next(a.Length), 1));
        }

        static void ejercicio16()
        {
            string a = System.Console.ReadLine();

            char b = a.Last();
            char c = a.First();

            a = a.Substring(1, a.Length - 1);

            System.Console.WriteLine(b + a + c);

        }

        static void ejercicio17()
        {
            string a = System.Console.ReadLine();

            char b = a.First();

            System.Console.WriteLine(b + a + b);

        }

        static void ejercicio18()
        {
            int a = int.Parse(System.Console.ReadLine());
            int b = int.Parse(System.Console.ReadLine());


            System.Console.WriteLine(a < 0 && b > 0 || a > 0 && b < 0);

        }

        static void ejercicio19()
        {
            int a = int.Parse(System.Console.ReadLine());
            int b = int.Parse(System.Console.ReadLine());


            System.Console.WriteLine(a == b ? (a + b) * 3 : a + b);

        }

        static void ejercicio20()
        {
            int a = int.Parse(System.Console.ReadLine());
            int b = int.Parse(System.Console.ReadLine());


            System.Console.WriteLine(a > b ? Math.Abs(a - b) * 2 : Math.Abs(a - b));

        }

        static void ejercicio21()
        {
            int a = int.Parse(System.Console.ReadLine());
            int b = int.Parse(System.Console.ReadLine());


            System.Console.WriteLine( a+b ==20 || a == 20 || b == 20 );

        }

        static void ejercicio22()
        {
            int a = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(a - 100 <= 20 || a - 200 <= 20);

        }

        static void ejercicio23()
        {
            string a = System.Console.ReadLine();

            System.Console.WriteLine(a.ToLower());

        }

        static void ejercicio24()
        {
            string a = System.Console.ReadLine();
            string longger = "";
            string[] aSplited = a.Split(' ');
            
            foreach (string iaSplited in aSplited )
            {
                if (iaSplited.Length > longger.Length)
                    longger = iaSplited;
            }

            System.Console.WriteLine(longger);

        }

        static void ejercicio25()
        {
            for (int i = 0; i <= 99; i++)
                System.Console.WriteLine(i);

        }

        static void ejercicio26()
        {
            int totalSum = 3;
            int nSum = 2;
            int i = 3;

            do
            {
                System.Console.Write(i + "\t");

                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        isPrime = false;
                }
                System.Console.Write(isPrime+"\t");

                if (isPrime)
                {
                    nSum += 1;
                    totalSum += i;
                }
                System.Console.Write(totalSum + "\n");

                i += 1;
            } while (nSum < 501);

            System.Console.WriteLine(totalSum);

        }


        // ==============================================================================================================


        private class hola
        {
           public static string a = "hola";
        }


        static void trySwitch()
        {
            string inputVar = "0";
            do
            {
                inputVar = System.Console.ReadLine();
                switch (inputVar)
                {
                    case "Lunes":
                        System.Console.WriteLine("es lunes");
                        break;
                    case "Martes":
                        System.Console.WriteLine("es Martes");
                        break;
                    case "Miercoles":
                        System.Console.WriteLine("es Miercoles");
                        break;
                    default:
                        System.Console.WriteLine("es mitad de semana en adelante");
                        break;
                }
            } while (inputVar != "0");
            
        }


        static void tryExceptionCatcher()
        {
            try
            {
                int.Parse("hola");
            }catch(Exception e)
            {
                System.Console.WriteLine("========= e ============");
                System.Console.WriteLine(e);
                System.Console.WriteLine("========== e.ToString() ===========");
                System.Console.WriteLine(e.ToString());
                System.Console.WriteLine("========== e.Message ===========");
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("========= e.InnerException ============");
                System.Console.WriteLine(e.InnerException);
                System.Console.WriteLine("=========== e.Source ==========");
                System.Console.WriteLine(e.Source);
                System.Console.WriteLine("=========== e.StackTrace ==========");
                System.Console.WriteLine(e.StackTrace);
                System.Console.WriteLine("========== e.TargetSite ===========");
                System.Console.WriteLine(e.TargetSite);
                System.Console.WriteLine("=====================");

            }
            finally
            {
                System.Console.WriteLine("||||||||||||||||||||||||||||||||||");
            }
        }


        static void tryTrhower()
        {
           int inputVar = int.Parse(System.Console.ReadLine());

            if (inputVar == 1)
                throw new Exception("Custom exception");
        }


        struct DiaYHora
        {
            public int a;
            public string b;

            public void display()
            {
                a = 1;
                b = "hola";
                System.Console.WriteLine(b + a);
            }
        }
        static void tryStructure()
        {
            DiaYHora a = new DiaYHora();
            a.display();
        }

        static void Main(string[] args)
        {
            tryStructure();
            System.Threading.Thread.CurrentThread.Suspend();
        }
    }
}
