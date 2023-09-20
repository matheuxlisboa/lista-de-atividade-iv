    using System;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        int idade;
        float salario;
        char sexo;
        char estadoCivil;

        while (true)
        {
            Console.Write("Digite o nome (maior que 3 caracteres): ");
            nome = Console.ReadLine();

            if (nome.Length > 3)
                break;
            else
                Console.WriteLine("Erro: o nome deve ter mais de 3 caracteres.");
        }

        while (true)
        {
            Console.Write("Digite a idade (entre 0 e 150): ");
            if (int.TryParse(Console.ReadLine(), out idade) && idade >= 0 && idade <= 150)
                break;
            else
                Console.WriteLine("Erro: a idade deve estar entre 0 e 150.");
        }

        while (true)
        {
            Console.Write("Digite o salário (maior que zero): ");
            if (float.TryParse(Console.ReadLine(), out salario) && salario > 0)
                break;
            else
                Console.WriteLine("Erro: o salário deve ser maior que zero.");
        }

        while (true)
        {
            Console.Write("Digite o sexo (f ou m): ");
            if (char.TryParse(Console.ReadLine(), out sexo) && (sexo == 'f' || sexo == 'm'))
                break;
            else
                Console.WriteLine("Erro: o sexo deve ser f ou m.");
        }

        while (true)
        {
            Console.Write("Digite o estado civil (s, c, v ou d): ");
            if (char.TryParse(Console.ReadLine(), out estadoCivil) && (estadoCivil == 's' || estadoCivil == 'c' || estadoCivil == 'v' || estadoCivil == 'd'))
                break;
            else
                Console.WriteLine("Erro: o estado civil deve ser s, c, v ou d.");
        }

        Console.WriteLine("Informações válidas:");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Sexo: " + sexo);
        Console.WriteLine("Estado Civil: " + estadoCivil);
    }
}