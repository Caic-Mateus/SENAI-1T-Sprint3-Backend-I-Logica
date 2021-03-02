using System;

namespace ProdutosCaic
{
    class Program
    {
        static void Main(string[] args)
        {

//             string[] nome = new string [10];
//             string login;
//             string senha;
//             float[] preco = new float [10];
//             bool promocao = true;
//             int [] desconto = new int [10];
//             float[] descontado= new float [10];
//             int opcoes;
//             int contador = 0;
//             string cadastrarProduto;

//             Console.Clear();
//             Console.WriteLine("-------------------------------------");
//             Console.WriteLine("--- BEM VINDO À CAIC FRAUDES ---");
//             Console.WriteLine("-------------------------------------");


//             Console.WriteLine("Faça login em nosso site para realizar suas compras.");
//             while( true ) {

            
//                 Console.WriteLine("Digite seu nome de usuario: ");
//                 login= Console.ReadLine();

//                 Console.WriteLine("Digite sua senha: ");
//                 senha= Console.ReadLine();

//                 if(login==senha){
//                     Console.WriteLine("O nome de usuario e senha não podem ser iguais");
//                 }
//                 else{break;}
//             }
//             Console.WriteLine("OK, seja bem vindo " + login);
//             Console.Clear();
//             do{
//                 System.Threading.Thread.Sleep(1000);
//                 Console.WriteLine("MENU:"); 
//                 Console.WriteLine("");
//                 Console.WriteLine("Escolha uma das opções abaixo:");
//                 Console.WriteLine("[1] Cadastrar Produtos.");
//                 Console.WriteLine("[2] Listar passagens");
//                 Console.WriteLine("[0] Sair");
//                 Console.Write("");
//                 Console.Write("Opção: ");
//                 opcoes = int.Parse(Console.ReadLine());
//                 Console.WriteLine("");
//                 switch(opcoes){
//                     case 1:
//                         Console.Clear();
//                         Console.WriteLine("Cadastrar Produtos:");
//                         Console.WriteLine("");
//                         do{
//                             if(contador < 10){
//                                 Console.Write($"Olá {login} Digite o nome do {contador+1}º produto: ");
//                                 nome[contador] = Console.ReadLine();
//                                 Console.WriteLine("");
                                

//                                 Console.Write("Qual o preço do produto? ");
//                                 preco[contador] = float.Parse(Console.ReadLine());
//                                 Console.WriteLine("");

//                                 Console.Write("O produto está em promoção? true/false ");
//                                 promocao = bool.Parse(Console.ReadLine());
//                                 Console.WriteLine("");
//                                 contador++;
                                
//                                 do
//                                 {
//                                     Console.WriteLine("qual o valor do desconto?");
//                                     desconto[contador] = int.Parse(Console.ReadLine());
//                                     Console.WriteLine("------------------------------");

//                                     descontado = preco;
                                    

//                                 } while (false);

                                
//                             }else{
//                                 Console.WriteLine("");
//                                 Console.WriteLine("Número de produtos atingido.");
//                             }

//                             Console.WriteLine("");
//                             Console.WriteLine("Gostaria de cadastrar outro produto? s/n");
//                             cadastrarProduto = Console.ReadLine();
//                             Console.WriteLine("");
//                         }while(cadastrarProduto == "s");
//                         break;
                    
//                     case 2:
//                         for (var i = 0; i < contador; i++){
//                             Console.WriteLine($"Total de Produtos: {contador}");
//                             Console.WriteLine("");
//                             Console.WriteLine($"Produto: {nome[i]} || Preço: {preco[i]} || Com o desconto: {desconto[i]} || ");                            
//                             Console.WriteLine("------------------------------------------------------------------------------------------------------");
//                         }
//                         break;

//                     case 0:
//                         Console.WriteLine("Origado pela preferencia, tenha um bom dia!");
//                         Console.WriteLine("-------------------------------------");
//                         Console.WriteLine("--- Todos os direitos pertencem a Caic Mateus ---");
//                         Console.WriteLine("-------------------------------------");
//                         Console.WriteLine("");
//                         break;

//                     default:
//                         Console.WriteLine("Operação inválida");
//                         break;                    
//                 }               
//             } while (opcoes != 0);

//         }
//     }
// }

            int escolha;
            bool [] promocao = new bool [2] ;
            int contador = 0;
            string resposta;
            string[] produto = new string [2];
            float[] preco = new float [2];

            Console.WriteLine("-------------------------");
            Console.WriteLine("--- BEM VINDO À CAIC FRAUDES ---");
            Console.WriteLine("-------------------------");

            do
            {   
                
                Console.WriteLine("Menu");
                Console.WriteLine("Selecione uma das opções:");
                Console.WriteLine("[1] Cadastrar produtos");
                Console.WriteLine("[2] Listar produtos");
                Console.WriteLine("[0] Sair");
                escolha = int.Parse(Console.ReadLine());
                
            switch (escolha)
                {   
                    case 1:
                        Console.WriteLine("Cadastro dos produtos");
                        do
                        {
                            if(contador < 2 ){
                            Console.WriteLine($"Digite o nome do {contador+1}º produto");
                            produto[contador] = Console.ReadLine();

                            Console.WriteLine($"Digite o preço do {contador+1} produto");
                            preco [contador] = float.Parse(Console.ReadLine());

                            Console.WriteLine($"Este produto está na promoção ? true/false ");
                            promocao [contador] = bool.Parse(Console.ReadLine());

                            contador++;

                            }else
                            {
                                Console.WriteLine("Limite de produtos excedido");
                                break;
                            }

                            Console.WriteLine("Gostaria de Cadastrar mais produtos ? S/N");
                            resposta = Console.ReadLine();
                        }while (resposta.ToUpper() == "S");

                        break;

                    case 2:
                        Console.WriteLine("Listar os produtos.");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"produto: {produto[i]}");
                            Console.WriteLine($"preço : {preco[i]}");
                            Console.WriteLine($"promoção : {promocao [i]}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("obrigado pela visita !");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                

            } 
   
            } while (escolha != 0);
        }
    }
}