namespace ExemploPOo.Models
{
    public class aluno : Pessoa
    {
       public int Nota { get; set; }


       public override void Apresentar()
       {
       
       Console.WriteLine($"meu nome é {nome} e minha nota é {Nota}");

       }
    }
}