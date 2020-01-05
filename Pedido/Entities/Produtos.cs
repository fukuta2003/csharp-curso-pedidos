using System.Globalization;

namespace Pedido.Entities
{
    class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos()
        {


        }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome + ", " + Preco.ToString("N",CultureInfo.InvariantCulture); 
        }


    }
}
