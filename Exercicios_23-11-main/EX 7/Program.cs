using System;

namespace EX_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[16];

            for (var i = 1; i <= 15; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                num[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Seus numeros de forma invertida são:");
            
            for (var inver = 15; inver > 0; inver--)
            {
                Console.WriteLine(num[inver]);
            }

        }
    
    }
}
