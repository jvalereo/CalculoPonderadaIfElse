using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula17,Calcula media pondera, tipo doulbe, if, else
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo double

            double nota1, nota2, peso1, peso2, soma, media;

            //Declarando as variaveis peso1, peso2;

            peso1 = 5.0;
            peso2 = 7.5;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a 1 nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a 2 nota: ");
            nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Declarando a variavel soma, dos peso1 e peso2

            soma = peso1 + peso2;

            //Declarando a variavel media da nota ponderada

            media = (peso1 * nota1 + peso2 * nota2) / soma;


            //imprimir saida de dados no console, método WhriteLine, concatenação

            //Declarando estrutura condicional if e else simples

            if(media >=7){

             Console.WriteLine("A media ponderada : " + media.ToString("F1",CultureInfo.InvariantCulture));
             Console.WriteLine();
             Console.WriteLine("Parabéns Aluno Aprovado...");

            }
              else
            {
                Console.WriteLine("A media ponderada : " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine();
                Console.WriteLine("Infelizmente Aluno Reprovado...");

            }

            // saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do progama
        
        }
    }
}
