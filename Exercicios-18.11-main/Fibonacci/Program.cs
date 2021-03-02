using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero :");
            int num;
                int x=1, y=0, z=0;
                    num = int.Parse(Console.ReadLine());

            double resp1 = y = x;
           double resp2 = x = z;
            for (int i = 0; i < num; i++ ){
            z = x + y;
            Console.Write( z + " ,");
             resp1 = y = x;
           resp2 = x = z;
                }
                Console.ReadLine();
            if(resp2 > 500){
                    Console.WriteLine("Atingido limite");
            }
            else{
                Console.WriteLine("boaaaaa");
            }
        }
    }
}

