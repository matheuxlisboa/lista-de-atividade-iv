using System;

class Program
{
    static void Main(string[] args)
    {
        float nota;

        while (true)
        {
            Console.Write("Insira uma nota entre zero e dez: ");
            if (float.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10)
                break;
            else
                Console.WriteLine("Valor inválido! Por favor, digite uma nota entre zero e dez.");
        }

        Console.WriteLine("Nota válida: " + nota);
    }
}