using System;

namespace EX_1
{
    class Program
    {
        static void Main(string[] args)
        {
//             1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
           
        
            Console.WriteLine("Insira o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora, insira o seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int calculo = anoAtual - anoNascimento;
            Console.WriteLine("Sua idade é: "+ calculo);

            int resultado = calculo;

            if( resultado <16 ){
                Console.WriteLine("Ops, você ainda não tem direito a voto");
            }
             else if ( resultado >15 && resultado<18 ){
                 Console.WriteLine("Você já tem escolha de voto, mas não é obrigado.");

            }
            else if(resultado>18 && resultado <70){
                Console.WriteLine("Voce é obrigado a votar.");
            }
           
            else if (resultado >=70 ){
                Console.WriteLine("Você não é mais obrigado, mas pode votar se quiser");
            }
                
            
        }
    }
}


