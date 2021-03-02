using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float salario;
            string estadocivil;

            do{
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu salario");
                salario = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu estado civil : s - Solteiro(a); c - casado(a) ; v - viuvo(a) ; d - divorciado(a)");
                estadocivil = (Console.ReadLine());

                if(nome ==""){
                    Console.WriteLine("O nome digitado é invalido, digite novamente"); nome=null;
                }

                if(idade <0 || idade>150){
                    Console.WriteLine("Idade invalida");
                }

                if( salario ==0){
                    Console.WriteLine("Salario invalido");

                }
                if(estadocivil == "s" || estadocivil=="c" || estadocivil== "v" || estadocivil=="d"){}

                else{
                    Console.WriteLine ("Estado civil invalido");
                }
            }
            while(nome == "" || idade == 1 || salario == 0 || estadocivil == "" );
            Console.WriteLine("Confirme seus dados");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salario: " + salario);
            Console.WriteLine("Estado Civil: " + estadocivil);

            Console.WriteLine("Validação efetuada");

        }
    }
}
