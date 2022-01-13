using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{       
        public static void Main(string[] args){
        Console.WriteLine("Qual é sua cor favorita?");
        String cor = Console.ReadLine();


        switch(cor){
        
        case "Vermelho":
        Console.WriteLine("Cor do Amor, legal.");
        break;
        
        case "Azul":
        Console.WriteLine("Cor do céu, interessante");
        break;

        case "Amarelo":
        Console.WriteLine("Cor do Brasil, dahora.");
        break; 
        
        default: Console.WriteLine("Ué"); break;}


        Modulo();

        Console.ReadLine();
        
        }

        enum Cor { Vermelho = 1, Amarelo, Azul }
        
        static void Modulo(){
        
        Cor corfavoritadogabriel = Cor.Amarelo;
        Cor corfavoritamaria = Cor.Vermelho;


        Console.WriteLine((int)corfavoritadogabriel);


        }
  






}

