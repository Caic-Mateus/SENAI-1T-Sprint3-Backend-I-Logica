using System;

namespace calculadora_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perguntar a operação
                Console.WriteLine("Qual a operação que você deseja realizar?? \nSoma, Subtracao, Multiplicacao, Divisao");
                string operacao = Console.ReadLine().ToLower();

            // Pedir o 1° numero
                Console.WriteLine("Digite o 1° numero :");
                float num1 = float.Parse( Console.ReadLine() );

            // Pedir o 2° numero
                Console.WriteLine("Digite o 2° numero :");
                float num2 = float.Parse( Console.ReadLine() );

            // Fazer o calculo
            // f = sufixo do float
                float resultado = 0;   


                switch (operacao){

                    case "soma":
                        resultado = num1 + num2;
                        break;
                     
                    case "subtracao":
                        resultado = num1 - num2;
                        break;

                    case "multiplicacao":
                        resultado = num1 * num2;
                        break;

                    case "divisao":
                        resultado = num1 / num2;
                        break;


                    default:
                        Console.WriteLine("Operação invalida :( ");
                        break;
                }
                



            // Mostrar o resultado 
            // interpolação
            Console.WriteLine($"Calculo : {num1} com {num2} = {resultado}");
        }
    }
}