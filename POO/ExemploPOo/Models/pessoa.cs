using System;


namespace ExemploPOo.Models
{
    public class Pessoa
    {
        public string nome { get; set; }

        public int idade { get; set; }

        public int documento { get; set; }

        public virtual void Apresentar()
        {

        Console.WriteLine($"Olá, meu nome é {nome} e eu tenho {idade} anos.");
        Console.WriteLine($"meu documento é {documento}");


        }
    }

}