using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string login ;
            string senha ;


            while( true ) {

            
                Console.WriteLine("Digite seu nome de usuario: ");
                login= Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                senha= Console.ReadLine();

                if(login==senha){
                    Console.WriteLine("O nome de usuario e senha não podem ser iguais");
                }
                else{break;}
            }
            Console.WriteLine("OK, seja bem vindo " + login);
        }
    }
}

