using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número inteiro:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número inteiro:");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Números no intervalo:");

        if (numero1 < numero2)
        {
            for (int i = numero1 + 1; i < numero2; i++)
            {
                Console.WriteLine(i);
            }
        }
        else if (numero2 < numero1)
        {
            for (int i = numero2 + 1; i < numero1; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Os números são iguais, não há intervalo.");
        }
    }
}