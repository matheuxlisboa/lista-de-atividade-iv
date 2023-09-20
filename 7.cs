using System;

class Program
{
    static void Main(string[] args)
    {
        int quantidadePares = 0;
        int quantidadeImpares = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Digite o {i}º número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                quantidadePares++;
            }
            else
            {
                quantidadeImpares++;
            }
        }

        Console.WriteLine($"Quantidade de números pares: {quantidadePares}");
        Console.WriteLine($"Quantidade de números ímpares: {quantidadeImpares}");
    }
}