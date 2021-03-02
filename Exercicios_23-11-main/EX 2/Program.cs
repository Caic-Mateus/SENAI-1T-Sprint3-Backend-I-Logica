using System;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
    { //2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.
            double litroG= 5.30;
            double litroA= 4.90;
            


            Console.WriteLine("Insira com o que você quer abastecer, G(gasolina ou A(alcool: ");
            string combustivel= Console.ReadLine();

            if(combustivel == "G"){
                Console.WriteLine("O litro da Gasolina está custando 5.30, quantos litros vai querer?");
                int litrosG= int.Parse(Console.ReadLine());

                if(litrosG <=20){
                   double valorG5= litroG * litrosG;
                   double porcentagem= valorG5 * 0.04;
                   Console.WriteLine("terá um desconto de:" +porcentagem);
                   double descontado= valorG5-porcentagem;
                   Console.WriteLine("O valor com 4% de desconto ficou: " + descontado);
                }
                else if(litrosG >20){
                    double valorG6= litroG * litrosG;
                   double porcentagem6= valorG6 * 0.06;
                   Console.WriteLine("terá um desconto de:" +porcentagem6);
                   double descontado= valorG6-porcentagem6;
                   Console.WriteLine("O valor com 6% de desconto ficou: " + descontado);
                }


            }
            if(combustivel == "A"){
                Console.WriteLine("O litro do Alcool está custando 4.90, quantos litros vai querer?");
                int litrosA= int.Parse(Console.ReadLine());
            
            if(litrosA <=20){
                   double valorA5= litroA * litrosA;
                   double porcentagem= valorA5 * 0.03;
                   Console.WriteLine("terá um desconto de:" +porcentagem);
                   double descontado= valorA5-porcentagem;
                   Console.WriteLine("O valor com 3% de desconto ficou: " + descontado);
                }
                else if(litrosA >20){
                    double valorA6= litroA * litrosA;
                   double porcentagem6= valorA6 * 0.05;
                   Console.WriteLine("terá um desconto de:" +porcentagem6);
                   double descontado= valorA6-porcentagem6;
                   Console.WriteLine("O valor com 5% de desconto ficou: " + descontado);
                }}
        }
    }
}
