using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int a = 0;
            int b = 0;
            string answer = "c";


            Console.WriteLine("Welcome to the calculator!");
            Console.ReadLine();
            Console.Clear();

            do
            {
                Console.WriteLine("What you want to do?");
                Console.WriteLine("1-Add");
                Console.WriteLine("2-Rest");
                Console.WriteLine("3-Multiply");
                Console.WriteLine("4-square root");
                Console.WriteLine("5-Potencia");
                Console.WriteLine("6-divide");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Please add the first number:");
                Console.WriteLine("Please add the second number:");

                switch (option)
                {
                    case 1:
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        a = add(a, b);
                        Console.WriteLine($"Result of add: {a} ");
                        break;
                    case 2:
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        a = rest(a, b);
                        Console.WriteLine($"Result: {a} ");
                        break;
                    case 3:
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        a = Multiply(a, b);
                        Console.WriteLine($"Result : {a} ");
                        break;
                    case 4:
                        square_root();
                        break;
                    case 5:
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        a = Potencia(a, b);
                        Console.WriteLine($"Result : {a} ");
                        break;
                    case 6:
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        a = divide(a, b);
                        Console.WriteLine($"Result : {a} ");
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Do you want to do something else? (s/n)");
                answer = Console.ReadLine();

            } while (answer == "s");
            
        }

        private static int add(int a,int b){ return a + b; }
        private static int rest(int a, int b) { return a - b; }
        private static int Multiply(int a, int b) { return a * b; }
        private static void square_root() 
        {
            Console.WriteLine("Coming soon");
        }
        private static int Potencia(int a, int b) 
        {
            int aux=a;
            for(int i=1; i <b; i++)
            {
                aux = aux * a;
            }
            return aux;
        }
        private static int divide(int a, int b) { return a / b; }
			Console.WriteLine("Coming soon");
    }
}
