using System;

namespace programa.cs
{
    class exercicio1
    {
        static int somaVetor(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
        }
    }
}
namespace programa.cs
{
    public class BibliotecaArray
    {
        public static void leiaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        } // fim leia vetor

        public static void leiaVetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = double.Parse(Console.ReadLine());
            }
        } // fim leia vetor

        public static void geraVetor(int[] vetor)
        {
            Random random = new Random(); // gerador de aleatorios
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);
            }
        } // fim gera vetor

        public static void geraVetor(double[] vetor)
        {
            Random random = new Random(); // gerador de aleatorios
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100) + random.NextDouble();
            }
        } // fim gera vetor

        public static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write($" | {vetor[i]}");

        }//  fim mostra vetor

        public static void mostraVetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write($" | {vetor[i]:F2}");

        }//  fim mostra vetor


    }
}

namespace programa.cs
{
    using System;

    class Program
    {
        static void Main()
        {
            double[] meuVetor = new double[5]; // declarando o vetor

            Console.WriteLine("*** Vetores em C# ***");
            Console.WriteLine("Entre com os valores para o vetor:");
            //  dados para o vetor
            BibliotecaArray.geraVetor(meuVetor);
            // mostrar dados do vetor
            Console.WriteLine("*** Vetor recebido ***");
            BibliotecaArray.mostraVetor(meuVetor);
            Console.ReadKey();
        }
    }

}
