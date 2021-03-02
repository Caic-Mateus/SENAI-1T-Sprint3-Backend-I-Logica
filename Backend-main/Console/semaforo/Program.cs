using System;

namespace semaforo
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite a cor do farol ? \n -verde\n -amarelo \n -vermelho  \n");
            string ColorSemaforo = Console.ReadLine();
            

            if(ColorSemaforo == "verde"){
            Console.WriteLine("o Sinal esta verde, pode passar!\n");
            } 
            else if(ColorSemaforo == "amarelo"){
                 Console.WriteLine("o sinal esta amarelo, reduza a velocidade e pare!\n");

            }
            else if(ColorSemaforo == "vermelho"){
                 Console.WriteLine("o sinal esta vermelho, não passe!\n");}

        }
    }
}