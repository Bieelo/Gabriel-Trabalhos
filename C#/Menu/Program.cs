using System;
using System.Collections.Generic;
using System.Linq;



public class Program
{
enum jogo
{FIFA = 1, COD, MINE, ZELDA}

    public static void Main(string[] args)
    {
     Console.WriteLine("Escolha um jogo:");       
     Console.WriteLine("1-FIFA\n2-COD\n3-MINE\n4-ZELDA");
     int index = int.Parse(Console.ReadLine());
     jogo opcaoselecionada = (jogo)index;
  
     switch (opcaoselecionada)
     {
         case jogo.FIFA:
         Console.WriteLine("Que jogo horrível");
             break;
         case jogo.COD:
         Console.WriteLine("É um bom jogo, mas já foi melhor");
             break;
         case jogo.MINE:
         Console.WriteLine("É o jogo perfeito");
             break;
         case jogo.ZELDA:
         Console.WriteLine("Nintendo é um lixo");
             break;

         default: 
         Console.WriteLine("Você precisa escolher um jogo!");
             break;
     }



    Console.ReadLine();
    }

static void caixa1()
{
   
   int contador = 0;
   while (contador < 10) //while : enquanto
   {
   Console.WriteLine("Carregando");




   }



   }









}