using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, p, imc;
            Console.WriteLine("\n---IMC---\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Para calcular a massa corporal, digite:");
            Console.ResetColor();

            Console.Write("\nAltura (m): ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Peso (kg).: ");
            p = Convert.ToDouble(Console.ReadLine());

            imc = p / Math.Pow(a, 2);


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n-Resultado-\n");
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"IMC: {imc:N2} kg/m²\n");
            Console.ResetColor();
        }
    }
}
