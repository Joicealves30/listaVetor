using System;

namespace Arrays
{
    public class BibliotecaArray
    {
        static void leiaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        } // fim leia vetor

        static void geraVetor(int[] vetor)
        {
            Random random = new Random(); // gerador de aleatorios
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);
            }
        } // fim gera vetor

        static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write($" | {vetor[i]}");

        }//  fim mostra vetor
        static void Main()
        {
            int[] meuVetor = new int[5]; // declarando o vetor

            Console.WriteLine("*** Vetores em C# ***");
            Console.WriteLine("Entre com os valores para o vetor:");
            //  dados para o vetor
            geraVetor(meuVetor);
            // mostrar dados do vetor
            Console.WriteLine("*** Vetor recebido ***");
            mostraVetor(meuVetor);
            Console.ReadKey();
        }
    }




}

