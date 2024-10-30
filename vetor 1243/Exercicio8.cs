using System;


class exercicio8
{
    static void Main()
    {
        Console.Write("Informe os caracteres separados por espaço: ");
        string[] ent = Console.ReadLine().Split(' ');

        char[] vetor = Array.ConvertAll(ent, char.Parse);

        Console.WriteLine("Vetor em ordem inversa:");
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write(vetor[i] + " ");
        }

        Console.WriteLine(); 
    }
}