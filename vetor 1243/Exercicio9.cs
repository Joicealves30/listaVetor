using System;
class Exercicio9
{
    static void Main()
    {
        Console.Write("Informe o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        Console.WriteLine("Preencha o vetor:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Informe o valor a ser buscado: ");
        int valor = int.Parse(Console.ReadLine());

        int cont = 0;
        foreach (int item in vetor)
        {
            if (item == valor) cont++;
        }

        Console.WriteLine($"O valor {valor} aparece {cont} vez(es).");
        Console.WriteLine("Elementos do vetor: " + string.Join(", ", vetor));
    }
}