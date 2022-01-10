using System;
using System.Collections.Generic;
using System.Linq;

namespace Meuapp
{
    public class Program
    {
          public static void Main(string[] args)//void significa vazio(é o tipo da função)
        {
           string[] produtos = new string[5]
           {"Cod","fifa","Gta","Mine","Cs"};

           Console.WriteLine(produtos[2]);

           caixa();
           gerarpreco("Mine", 101);
           int soma1 = somar(10,20,30);
           int soma2 = somar(30,60,90);



          Console.WriteLine(soma1 + soma2);

          Console.ReadLine();
        }

          static void caixa()
          {
            Console.WriteLine("Qual jogo é melhor?");
     

          }

          static void gerarpreco(string opniao, int preco)
          {
          Console.WriteLine(opniao);

          int valor = preco + (2 * 8 + preco);
          Console.WriteLine("Preço do jogo: "+ valor); 
          
          }

          static int somar(int a, int b, int c)
          {
         
          int resultado = a + b + c;
         return resultado;


          }
         

    }
}
