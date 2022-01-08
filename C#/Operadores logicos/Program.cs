using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{ 
    public static void Main(string[] args)
        {
           Console.WriteLine("Digite seu nome: ");
           string nome = Console.ReadLine();

           Console.WriteLine("Digite sua nota");
           float nota1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Digite sua nota");
           float nota2 = float.Parse(Console.ReadLine());

           Console.WriteLine("Digite sua nota");
           float nota3 = float.Parse(Console.ReadLine());

           Console.WriteLine("Digite sua nota");
           float nota4 = float.Parse(Console.ReadLine());

           float media = (nota1+nota2+nota3+nota4)/4; 

           Console.WriteLine( nome +", sua média é de: "+ media);

           Console.ReadLine();
           
           if(media > 6)
           {
           Console.WriteLine("Você passou de ano!");
           }

           else
           {
           Console.WriteLine("Você não passou");
           }


        }
}