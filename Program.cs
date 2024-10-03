﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Kalkylator");
        Console.WriteLine("Välj en operation (+, -, *, /):");
        char operation = Console.ReadKey().KeyChar;

        Console.WriteLine("\nAnge första talet:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ange andra talet:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Fel: Ogiltig operation.");
                return;
        }

        Console.WriteLine($"Resultat: {result}");
        Console.ReadKey();
        //test
    }
}