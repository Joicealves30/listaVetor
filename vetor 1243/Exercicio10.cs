using System;

class Exercicio10
{
    static void Main()
    {
        Console.Write("Informe a quantidade de lançamentos: ");
        int n = int.Parse(Console.ReadLine());
        int[] lancamentos = new int[n];

        Console.WriteLine("Informe os resultados dos lançamentos (valores entre 1 e 6):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Lançamento {i + 1}: ");
            lancamentos[i] = int.Parse(Console.ReadLine());
        }

        int[] ocorrencias = new int[6]; // Índices 0-5 correspondem às faces 1-6

        foreach (int face in lancamentos)
        {
            if (face >= 1 && face <= 6)
                ocorrencias[face - 1]++;
        }

        Console.WriteLine("Número de ocorrências de cada face:");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Face {i + 1}: {ocorrencias[i]} vez(es)");
        }
    }
}