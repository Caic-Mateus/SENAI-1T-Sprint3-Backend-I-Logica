using System;

namespace ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = {"maça", "batata", "cenoura"} ;
            double[] preços = {1.1, 2.3, 4.5};
            int [] idades = {16, 15, 18};

            string[] nomesAlunos = new string[5];

            // Console.WriteLine(produtos[1]);

            // Console.WriteLine("Trocar batata por qual item?");

            // produtos[1] = Console.ReadLine();

            // Console.WriteLine(produtos[1]);

            //Console.WriteLine(produtos.Length);

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(produtos[i]);
            }

           
          
    
}
    }
}