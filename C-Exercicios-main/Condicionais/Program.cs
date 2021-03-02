using System;

namespace semaforo
{
    class Program
    {
        static void Main(string[] args)
        {
           
           //Para participar do time de cs, precisa ter média maior ou igual a 80 
           //E faltas menor ou igual a 10 dos dias letivos ;
           
           Console.WriteLine("Bem vindo a seletiva para o time de CS");
            Console.WriteLine("-------------------------------------------------");
           
            Console.WriteLine("Você gostaria de participar? Sim ou Não ");
            string resposta = Console.ReadLine(); 

            if( resposta == "Sim" ) {
                Console.WriteLine("Que legal, agora precisamos analisar o seu curriculo. ");
    Console.WriteLine("Insira a sua média escolar. ");
    int media = int.Parse(Console.ReadLine());
     Console.WriteLine("Insira a quantidade de faltas. ");
    int faltas = int.Parse(Console.ReadLine());
    if( media >= 50 && faltas <=10){
        Console.WriteLine("Parabéns, seja bem vindo ao time! ");
    }else{
        Console.WriteLine("Que pena, suas notas e médias não se encaixam em nosso time.");
    
    
}

            }
            else{
                 Console.WriteLine("Beleza, passar bem! ");
            }
        }
    }
}