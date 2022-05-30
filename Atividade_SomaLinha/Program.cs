using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Atividade - Soma Linha");
        Console.WriteLine();

        int M, N, i, j;

        Console.WriteLine("Qual a quantidade de linhas da matriz? ");
        M = int.Parse(Console.ReadLine());
        Console.WriteLine("Qaul a quantidade de colunas da matriz");
        N = int.Parse(Console.ReadLine());


        float[,] mat = new float[M, N];
        float[] vet = new float[M];

        for (i = 0; i < M; i++)
        {
            Console.WriteLine("Digite os elementos da " + (i + 1 )+ " a linha:");

            for (j = 0; j < N; j++)
            {
                mat[i, j] = float.Parse(Console.ReadLine());
            }
        }

        for (i = 0; i < M; i++)
        {
            vet[i] = 0;

            for (j = 0; j < N; j++)
            {
                vet[i] += mat[i, j];
            }

        }

        Console.WriteLine("VETOR GERADO:");
        for (i = 0; i < M; i++)
        {
            Console.WriteLine(vet[i]);
        }




        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}