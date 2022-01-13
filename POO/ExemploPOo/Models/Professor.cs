namespace ExemploPOo.Models
{
    public class Professor : Pessoa
    {
     public double salario { get; set; }

     public override void Apresentar()
     {
     
     Console.WriteLine($"Meu nome é {nome} e eu recebo {salario}");

     }
    }
}