using System;


using System;


namespace atividadeDNA
{
    internal class Exercicio11

    {
        static void Main()
        {
            string frase;
            Console.WriteLine("Entre com frase:");
            frase = Console.ReadLine();
            for (int i = 1; i < frase.Length - 1; i++)
            {
                if (frase[i] != 'p')
                {
                    Console.Write(frase[i]);

                }
                else
                {
                    if (frase[i - 1] == 'p' && frase[i + 1] == 'p')
                        Console.Write(frase[i]);
                }
            }
            Console.ReadKey();
        }
    }
}