
using System;

namespace EnkelKalkylator
{

    public class Kalk
    {
        public double addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double substraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Kalk();


            Console.WriteLine("Enkel Kalkylator");
            Console.WriteLine("Ange operation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;

            Console.WriteLine("\nAnge första talet: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ange andra talet: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = calc.addition(num1, num2);
                    break;
                case '-':
                    result = calc.substraction(num1, num2);
                    break;
                case '*':
                    result = calc.multiplication(num1, num2);
                    break;
                case '/':
                    result = calc.division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Ogiltig operation.");
                    return;
                    
            }

            Console.WriteLine($"Resultat: {result}");
            Console.ReadKey();

        }
    }
}