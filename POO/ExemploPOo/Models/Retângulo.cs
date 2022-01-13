namespace ExemploPOo.Models
{
    public class Retângulo
    {
        private double comprimento; //propriedades
        private double largura;
        private bool valido;

        public void DefinirMedidadas(double comprimento, double largura) //método
        {

        if(comprimento > 0 && largura > 0)
        {

        this.comprimento = comprimento;
        this.largura = largura;
        valido = true;
        
        }
        else{ System.Console.WriteLine("valores invalidos"); }
        
        }

    public double ObterArea()
    {
    if (valido)
    {
    return comprimento * largura;
    }
    else
    {
    System.Console.WriteLine("preencha valores validos");
    return 0;


    }


    }

    }
}