using System.Globalization;
using System.Text;

namespace Pedido.Entities
{
    class ItensPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produtos Produto { get; set; }

        public ItensPedido()
        {

        }
        public ItensPedido(Produtos produto, int quantidade, double preco)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            StringBuilder wits = new StringBuilder();

            wits.AppendLine("NOME DO PRODUTO.......:" + Produto.Nome);
            wits.AppendLine("PREÇO DO PRODUTO......:" + Preco.ToString("C", CultureInfo.CurrentCulture));
            wits.AppendLine("QUANTIDADE............:" + Quantidade);
            wits.AppendLine("SUB TOTAL DO PRODUTO..:" + SubTotal().ToString("C", CultureInfo.CurrentCulture));

            return wits.ToString();

        } 

    }
}
