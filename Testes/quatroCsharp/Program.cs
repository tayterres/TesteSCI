using System;

namespace quatroCsharp

{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[5];
            Console.WriteLine("Digite 5 números");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("O numero na posicao 3 é :" + numeros[2]);
        }   
    }
}