using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Digite o nome de usuário: ");
            string nomeUsuario = Console.ReadLine();

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            if (senha != nomeUsuario)
                break;
            else
                Console.WriteLine("Erro: a senha não pode ser igual ao nome de usuário. Por favor, tente novamente.");
        }

        Console.WriteLine("Cadastro realizado com sucesso!");
    }
}