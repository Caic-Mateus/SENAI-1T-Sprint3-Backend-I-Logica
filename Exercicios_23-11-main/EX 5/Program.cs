using System;

namespace EX_5
{
    class Program
    {
        static void Main(string[] args)
        {
//             5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
Console.WriteLine("Você deseja ver a tabuada de qual numero?");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;
        for (int i =0 ; i < 1;  i++)
        {
            
        
            for (int contador = 0; contador <=10; contador++)
            {
                resultado = resposta * contador;
                Console.WriteLine($" {resposta} * {contador} = {resultado}");
            
                System.Threading.Thread.Sleep(1000);
            }
        }}
    }
}
