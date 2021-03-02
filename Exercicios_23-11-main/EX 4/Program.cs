using System;

namespace EX_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.

            int maior=0 , menor=0 , quantidade=10;
            float x =0;

            int[] num = new int [10];
            Console.WriteLine( "Informe 10 numeros" );
            

            Console.WriteLine("Informe o 1 numero: ");
            int numero= int.Parse(Console.ReadLine());
            maior = numero;
            menor = numero;
            x=0;

            for (x = 1; x < quantidade; x++)
            {
                Console.WriteLine("Informe o "+x+" numero: " );
                numero= int.Parse(Console.ReadLine());

                if( numero < menor){
                    menor=numero;
                }
                if (numero> maior){
                    maior= numero;
                }
            }
                Console.WriteLine("O maior numero é: " + maior);
                Console.WriteLine("O menor numero é: " + menor);
        }
    }
}
            
