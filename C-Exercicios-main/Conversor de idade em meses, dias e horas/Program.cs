using System;

namespace Conversor_de_idade_em_meses__dias_e_horas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você deseja converter sua idade em meses, dias, horas e minutos? Sim ou Não. ");
            string resposta = Console.ReadLine();
            if( resposta == "Sim"){

            Console.WriteLine("Digite sua idade.");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12 ;
            int dias = idade * 365;
            int horas = idade * 8760;
            int minutos = idade * 525600;

            string convertmeses = "";
            Console.WriteLine ("A sua idade em meses é : " + meses);

            Console.WriteLine("-----------------------------------");

            string convertdias = "";
            Console.WriteLine("A sua idades em dias é : " + dias);
            Console.WriteLine("-----------------------------------");

            string converthoras = "";
            Console.WriteLine("A sua idades em horas é : " + horas);
            Console.WriteLine("-----------------------------------");

            string convertminutos = "";
            Console.WriteLine("A sua idades em minutos é : " + minutos);
            Console.WriteLine("-----------------------------------");}

            else{
                Console.WriteLine("Ok, passe bem");
            }

        }
    }
}
