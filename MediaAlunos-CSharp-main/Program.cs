using System;

namespace Media_Alunos
{
    class Program
    {   

        static float CalcularMedia( float[] numeros ){

            float soma = 0;
            for (var i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i] ;
            }

            float resultado = soma / numeros.Length;

            return resultado;
        }

        static void Main(string[] args)
        {
            string[] nomes = new string [2];
            float[] notas = new float[4];
            float[] media= new float [2];

            // Array.length= tamanho do array
            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o nome do aluno");
                nomes[i] = Console.ReadLine();
                
                for (int n = 0; n < notas.Length; n++)
                {
                    Console.WriteLine("Digite a "+(n+1)+"° nota:");
                    notas[n] = float.Parse( Console.ReadLine());

                }  
                //Calculamos a média fora do laço de notA 

                media[i] = CalcularMedia(notas);
                }

                //Laços condicionais
                foreach(string nome in nomes)
                {Console.WriteLine(nome);}

                //Mostramos as infos 

                for (int i = 0; i < nomes.Length; i++)
                {
                    //interpolaçao
                    Console.WriteLine($"Nome : {nomes[i]} Média: {media[i]} ");
                }

                Console.WriteLine("Média geral da turma: " + CalcularMedia(media));
                
                
                Console.WriteLine("");
            Console.WriteLine("Os alunos que passaram de ano foram:");

            for(int i = 0; i < 2; i++){
                if(media[i] >= 7){
                    Console.WriteLine($"{nomes[i]} com a média alta de {media[i]} passou!");
                }else{
                    Console.WriteLine("");
                    Console.WriteLine("Os alunos que reprovaram de ano foram:");
                    Console.WriteLine($"{nomes[i]} com a média baixa de {media[i]} reprovou!");
                }
            }
                 

    }

}
}              