using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculatrice C# ===");

        double num1,
            num2;
        string input;

        // Premier nombre
        while (true)
        {
            Console.Write("Premier nombre: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && double.TryParse(input, out num1))
                break;
            Console.WriteLine("Entrée invalide. Veuillez entrer un nombre valide.");
        }

        // Opérateur
        char op;
        while (true)
        {
            Console.Write("Opérateur (+, -, *, /): ");
            input = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(input) && input.Length == 1)
            {
                op = input[0];
                if ("+-*/".Contains(op))
                    break;
            }
            Console.WriteLine("Opérateur invalide. Utilisez +, -, * ou /.");
        }

        // Deuxième nombre
        while (true)
        {
            Console.Write("Deuxième nombre: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && double.TryParse(input, out num2))
            {
                if (op == '/' && num2 == 0)
                {
                    Console.WriteLine(
                        "Division par zéro impossible. Veuillez entrer un autre nombre."
                    );
                    continue;
                }
                break;
            }
            Console.WriteLine("Entrée invalide. Veuillez entrer un nombre valide.");
        }

        double result = op switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num1 / num2,
            _ => double.NaN
        };

        Console.WriteLine($"Résultat: {result}");
    }
}
