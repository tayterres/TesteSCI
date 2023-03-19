using System;

namespace tresCsharp;

class Program
{
    static void Main(string[] args)
    {
        string[,] matriz = new string[3, 5];
        int alunoMaiorMedia = 0, alunoMenorMedia = 0;
        double mediaMaior = 0.0, mediaMenor = 10.0;
        double[] mediasAlunos = new double[3];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine("Informe o nome do aluno " + (i + 1));
            matriz[i, 0] = Console.ReadLine();

            double media = 0;

            for (int j = 1; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine("Informe a nota do aluno " + matriz[i, 0]);
                matriz[i, j] = Console.ReadLine();
                media = media + double.Parse(matriz[i, j]);
            }
            media = media / 4;

            mediasAlunos[i] = media;

            if (media > mediaMaior)
            {
                mediaMaior = media;
                alunoMaiorMedia = i;
            }

            if (media < mediaMenor)
            {
                mediaMenor = media;
                alunoMenorMedia = i;
            }
        }
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine("A Média do Aluno " + matriz[i, 0] + " É " + mediasAlunos[i]);
        }
        Console.WriteLine("Aluno com a maior média é " + matriz[alunoMaiorMedia, 0]);
        Console.WriteLine("Aluno com a menor média é " + matriz[alunoMenorMedia, 0]);
    }
}