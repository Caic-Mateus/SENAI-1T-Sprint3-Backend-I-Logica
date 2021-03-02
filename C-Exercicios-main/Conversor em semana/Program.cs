using System;

namespace Conversor_em_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu ano de nascimento.");
            int nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira sua idade atual. ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Você deseja converter sua idades em semanas? Sim ou não. ");
            string resposta= Console.ReadLine();
            if( resposta == "Sim"){
                int semanas = idade * 52;

                Console.WriteLine("-----------------------------------");
                string resultnascimento ="";
                Console.WriteLine("Seu ano de nascimento é: " + nascimento);
                Console.WriteLine("-----------------------------------");

                string idadeatual = "";
                Console.WriteLine("Sua idade atual é: " + idade);
                Console.WriteLine("-----------------------------------");

                string convertsemanas = "";
                Console.WriteLine ("A sua idade em semanas é : " + semanas);
                Console.WriteLine("-----------------------------------");
            }

            else{
                Console.WriteLine(" Ok, Passe bem");
            }
        }
    }
}
