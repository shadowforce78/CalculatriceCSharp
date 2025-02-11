using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculatrice C# ===");

        Console.Write("Premier nombre: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Opérateur (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Deuxième nombre: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = op switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 != 0 ? num1 / num2 : double.NaN,
            _ => double.NaN
        };

        Console.WriteLine($"Résultat: {result}");
    }
}
