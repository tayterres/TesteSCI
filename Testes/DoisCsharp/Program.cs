using System;

namespace DoisCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, nMaior = int.MinValue, nMenor = int.MaxValue;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Digite o número " + i);
                numero = int.Parse(Console.ReadLine());

                if (numero > nMaior)
                {
                    nMaior = numero;
                }

                if (numero < nMenor)
                {
                    nMenor = numero;
                }
            }

            Console.WriteLine("O número maior é: ", nMaior);
            Console.WriteLine("O número menor é: ", nMenor);
        }      
    }
}    
           
