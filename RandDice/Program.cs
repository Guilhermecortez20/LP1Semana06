using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Uso: dotnet run -- <número de dados> <semente>");
            return;
        }

        if (!int.TryParse(args[0], out int n) || !int.TryParse(args[1], out int s))
        {
            Console.WriteLine("Erro: Certifique-se de que ambos os parâmetros são números inteiros.");
            return;
        }

        Random rand = new Random(s);
        int soma = 0;

        for (int i = 0; i < n; i++)
        {
            soma += rand.Next(1, 7); 
        }

        Console.WriteLine(soma);
    }
}
