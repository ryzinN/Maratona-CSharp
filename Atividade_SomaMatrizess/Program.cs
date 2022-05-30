﻿using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Atividade - Soma Matrizes");
        Console.WriteLine();

        int m, n, i, j;

        float[,] a = new float[9, 9];
        float[,] b = new float[9, 9];
        float[,] c = new float[9, 9];

        Console.WriteLine("Quantas linhas vai ter cada matriz? ");
        m = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantas colunas vai ter cada matriz? ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valores da MATRIZ A: ");

        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                a[i, j] = float.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Digite o valores da MATRIZ B: ");

        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                b[i, j] = float.Parse(Console.ReadLine());
            }
        }

        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                c[i, j] = a[i, j] + b[i, j];   
            }
        }

        Console.WriteLine("MATRIZ SOMA: ");

        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.WriteLine(c[i,j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}