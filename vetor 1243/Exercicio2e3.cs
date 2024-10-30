using System;
using Arrays;

namespace programa.cs
{
    internal class exercicio2
    {
        static double maiorValor(double[] vetor)
        {
            double maior = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                    maior = vetor[i];
            }//fim for
            return maior;
        }

        static double menorValor(double[] vetor)
        {
            double menor = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {

                if (vetor[i] > menor)
                    menor = vetor[i];
            }//fim for
            return menor;

        }


        static void Main()
        {
            int n;
            Console.WriteLine("Tamanho do vetor:");
            n = int.Parse(Console.ReadLine());
            double[] numeros = new double[n];
            BibliotecaArray.geraVetor(numeros);
            BibliotecaArray.mostraVetor(numeros);
            double res = maiorValor(numeros);
            Console.WriteLine($"Maior Valor:{res:F2}");
            Console.WriteLine($"Menor valor:{menorValor(numeros):F2}");
            Console.ReadKey();

        }
    }
}




