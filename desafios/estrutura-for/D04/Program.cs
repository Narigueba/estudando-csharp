/* Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel". */

using System;
using System.Globalization;

namespace D04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) { 
            
                string[] line = Console.ReadLine().Split(' ');

                int a = int.Parse(line[0]);
                int b = int.Parse(line[1]);

                if (b == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else 
                {
                    double divisao = ((double)a / b);
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}