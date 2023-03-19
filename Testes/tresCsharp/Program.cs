using System;

namespace tresCsharp;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        double nota1, nota2, nota3, nota4, media;
        char resposta = 's';

        while (resposta == 's' || resposta == 'S')
        {
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Aluno: " + nome);
            Console.WriteLine("Média: " + media);

            if (media >= 6)
            {
                Console.WriteLine("Situação: Aprovado");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");
            }

            Console.Write("Deseja continuar (s/n)? ");
            resposta = Console.ReadLine()[0];
        }
    }
}