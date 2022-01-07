using System;

class Variaveis 
{
    static void Main()
    {
    
    int a = 80;
    int b = 100;
    int c = (a + b);
    
    
    if (c >= 100) //se a variavel C é maior ou igual a 31
    {
    Console.WriteLine("É verdade");
    }

    else if (c < 10)
    {
    Console.WriteLine("Você é idiota por a caso?");
    }


    else //senão 
    {
    Console.WriteLine("É mentira");
    }
    
    
    Console.ReadLine();

    }
}
