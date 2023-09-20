using System;

class Program
{
    static void Main(string[] args)
    {
        int quantidadeNumeros = 5;
        int soma = 0;

        for (int i = 1; i <= quantidadeNumeros; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            soma += numero;
        }

        double media = (double)soma / quantidadeNumeros;

        Console.WriteLine($"A soma dos números é: {soma}");
        Console.WriteLine($"A média dos números é: {media}");
    }
}