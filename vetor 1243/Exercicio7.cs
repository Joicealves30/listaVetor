﻿using System;

class atividade07
{
    static void Main()
    {
        Console.Write("Informe o tamanho dos vetores: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor1 = new int[n];
        int[] vetor2 = new int[n];
        int[] resultado = new int[n];

        Console.WriteLine("Preencha o primeiro vetor:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Preencha o segundo vetor:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            resultado[i] = vetor1[i] * vetor2[i];
        }

        Console.WriteLine("Vetor resultante da multiplicação:");
        Console.WriteLine(string.Join(", ", resultado));
    }
}