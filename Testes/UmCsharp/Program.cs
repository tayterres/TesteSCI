using System;

namespace UmCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            double soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite o número " + (i + 1));
                string numeroUsuario = Console.ReadLine();

                numeros[i] = int.Parse(numeroUsuario);
            }

            string numerosPares = "";
            string numerosImpares = "";

            foreach (int numero in numeros)
            {
                soma += numero;

                if (numero % 2 == 0)
                {
                    numerosPares += numero + " ";
                }
                else
                {
                    numerosImpares += numero + " ";
                }
            }
            
            Console.Write("Números pares: ");
            Console.Write(numerosPares);
            Console.WriteLine();
            Console.Write("Números ímpares: ");
            Console.Write(numerosImpares);
            Console.WriteLine();

            double media = soma / numeros.Length;
            Console.WriteLine("Média geral: " + media);
        }
    }
}