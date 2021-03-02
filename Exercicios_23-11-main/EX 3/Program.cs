using System;

namespace EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
//             //3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else
            int ps5 = 5000;


            Console.WriteLine("Olá o ps5 custa 5000 a unidade, quantos deseja adiquirir?");
            int quantidade = int.Parse(Console.ReadLine());

            float valor = quantidade * ps5;

            Console.WriteLine("O valor a ser pago é de: " + valor);

            if(quantidade <= 5){
               double desconto= -valor * -0.02 ;
               Console.WriteLine("o desconto de 2% ficará: "+ desconto);
               double descontado = valor-desconto;
               Console.WriteLine("O valor agora é de: " +descontado);
            }
            else if(quantidade>5 && quantidade<+10){
                double desconto3= -valor * -0.03 ;
               Console.WriteLine("o desconto de 3% ficará: "+ desconto3);
               double descontado3 = valor-desconto3;
               Console.WriteLine("O valor agora é de: " +descontado3);
            }
            else if(quantidade>10){
                double desconto5= -valor * -0.05 ;
               Console.WriteLine("o desconto de 5% ficará: "+ desconto5);
               double descontado5 = valor-desconto5;
               Console.WriteLine("O valor agora é de: " +descontado5);
            }


        }
    }
}
