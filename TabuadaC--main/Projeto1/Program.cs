using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Você deseja receber um bom dia?");
            string resposta = Console.ReadLine();

            int numerodevezes = 0;


            while (resposta == "Sim")
            //Executado quando a condição é verdadeira 
            {
                Console.WriteLine("Bom dia !!");

                numerodevezes++;

                Console.WriteLine("Ainda deseja receber um bom dia? ");
                resposta = Console.ReadLine();
            }

           
            Console.WriteLine($"Numero de bom dias recebidos: {numerodevezes}");
            Console.WriteLine("Fim do programa");

        }
    }
}
