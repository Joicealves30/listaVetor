using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe as cinco notas separadas por espaço:");
        string[] entrada = Console.ReadLine().Split(' ');

        // Converter a entrada para um array de números decimais
        decimal[] notas = Array.ConvertAll(entrada, decimal.Parse);

        // Ordenar o array de notas em ordem crescente
        Array.Sort(notas);

        // Calcular a soma das três notas centrais (excluindo a menor e a maior)
        decimal notaFinal = notas[1] + notas[2] + notas[3];

        // Exibir a nota final com uma casa decimal
        Console.WriteLine(notaFinal.ToString("F1"));
    }
}