using System;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int contador = 6; contador <= 10; contador ++)
            {
                //Codigo a se repetir
            Console.WriteLine(contador);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Bom dia!");
            }
        }

    }
}
