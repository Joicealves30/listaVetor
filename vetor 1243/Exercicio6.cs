using System;

 public class Exercicio6
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Random random = new Random();

        for (int i = 0; i < n; i++)
            vetor[i] = random.Next(1, 101);

        int numeroBuscado = int.Parse(Console.ReadLine());
        int posicao = Array.IndexOf(vetor, numeroBuscado);

        Console.WriteLine(posicao != -1 ? $"Encontrado na posição {posicao}" : "Número não encontrado");
    }
}