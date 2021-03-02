using System;

namespace ProjetoViagens
{
    class Program
    {
        static void Main(string[] args)
        {
            string refazercadastro;
            int contador = 0;
            int opcoes;
            bool senhacerta;
            string login;
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--- BEM VINDO À AGÊNCIA CAICZZZ ---");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            do{
            Console.WriteLine("Login:");
            login = Console.ReadLine();
            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();
            senhacerta = Login(senha);
            }while(!senhacerta); //sinal de negação (que é false)

                Console.Clear();
            do{
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("MENU:"); 
                Console.WriteLine("");
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("[1] Cadastrar passagem.");
                Console.WriteLine("[2] Listar passagens");
                Console.WriteLine("[0] Sair");
                Console.Write("");
                Console.Write("Opção: ");
                opcoes = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch(opcoes){
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Cadastrar passagens:");
                        Console.WriteLine("");
                        do{
                            if(contador < 5){
                                Console.Write($"Olá {login} Digite o nome do {contador+1}º passageiro: ");
                                nomes[contador] = Console.ReadLine();
                                Console.WriteLine("");
                                

                                Console.Write("Ponto de origem do passageiro: ");
                                origem[contador] = Console.ReadLine();
                                Console.WriteLine("");

                                Console.Write("Destino do passageiro: ");
                                destino[contador] = Console.ReadLine();
                                Console.WriteLine("");

                                Console.Write("Data da viagem: ");
                                data[contador] = Console.ReadLine();
                                Console.WriteLine("");

                                contador++;
                            }else{
                                Console.WriteLine("");
                                Console.WriteLine("Número de passageiros excedido.");
                            }

                            Console.WriteLine("");
                            Console.WriteLine("Gostaria de cadastrar outro passageiro? s/n");
                            refazercadastro = Console.ReadLine();
                            Console.WriteLine("");
                        }while(refazercadastro == "s");
                        break;
                    
                    case 2:
                        for (var i = 0; i < contador; i++){
                            Console.WriteLine($"Total de Passageiros: {contador}");
                            Console.WriteLine("");
                            Console.WriteLine($"Passageiro: {nomes[i]} || Com a origem: {origem[i]} || Com o destino: {destino[i]} || Na data: {data[i]} ||");                            
                            Console.WriteLine("------------------------------------------------------------------------------------------------------");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Origado pela preferencia, tenha um bom dia!");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("--- Todos os direitos pertencem a Caic Mateus ---");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("Operação inválida");
                        break;                    
                }               
            } while (opcoes != 0);





            //Função:
            bool Login(string senha){
                if(senha == "123456"){
                    return true;
                }else{
                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Senha inválida");
                    Console.WriteLine("Digite novamente!");
                    

                    return false;
                }
            }
        }
    }
}