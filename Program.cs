


public class Kaklkyleringar
{
    public void addition()
    {

    }

    public void substraction()
    {

    }

    public void multiplication()
    {

    }

    public void division()
    {

    }
}
public class Program
{
    private static void Main(string[] args)
    {
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
                Console.WriteLine("Ogiltig operation.");
                return;
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
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Fel: Division med noll är inte tillåten.");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Ogiltig operation.");
                        return;
                }
                Console.WriteLine($"Resultat: {result}");
                Console.ReadKey();
        }

        Console.WriteLine($"Resultat: {result}");
        Console.ReadKey();
        static double LäsInTal()
        {
            double tal;
            while (!double.TryParse(Console.ReadLine(), out tal))
            {
                Console.WriteLine("Felaktig inmatning, ange ett giltigt tal:");
            }
            return tal;
        }
    }
}