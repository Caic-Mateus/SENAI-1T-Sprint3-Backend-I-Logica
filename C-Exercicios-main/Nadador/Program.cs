using System;

namespace desafio___nadador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem vindo à academia de natação, temos que saber em qual categoria está!");
            Console.WriteLine("");

            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if(idade >= 5 && idade <= 7){
            Console.WriteLine("Você entrou para a categoria Infantil A!");
            Console.WriteLine("");
            }

            if(idade >= 8 && idade <= 10){
            Console.WriteLine("Você entrou para a categoria Infantil B!");
            Console.WriteLine("");
            }

            if(idade >= 11 && idade <= 13){
            Console.WriteLine("Você entrou para a categoria Juvenil A!");
            Console.WriteLine("");
            }

            if(idade >= 14 && idade <= 17){
            Console.WriteLine("Você entrou para a categoria Juvenil B!");
            Console.WriteLine("");
            }

            if(idade >= 18){
            Console.WriteLine("Você entrou para a categoria Sênior!");
            Console.WriteLine("");
            }
        }
    }
}
