using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int nota ;

            do{
                Console.WriteLine("Digite um numero de 0 a 10: ");
                nota= int.Parse(Console.ReadLine());

                if(nota <0 || nota >10){
                    Console.WriteLine("Ops, o algoritmo digitado é invalido, digite novamente");

                }

            }

            while(nota<0 || nota >10);

            Console.WriteLine("Algoritmo valido!");
        }
    }
}
