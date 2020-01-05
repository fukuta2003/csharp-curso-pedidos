using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Pedido.Entities;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Repetir("=", 50);
            Console.WriteLine("PEDIDOS");
            Repetir("=", 50);

            Console.WriteLine("ENTRE COM OS DADOS DO CLIENTE:");
            Console.Write("ID.......................:");
            int wid = int.Parse(Console.ReadLine());
            Console.Write("NOME.....................:");
            string wnome = Console.ReadLine();
            Console.Write("EMAIL....................:");
            string wemail = Console.ReadLine();
            Console.Write("Nascimento DD/MM/YYYY....:");
            DateTime wdatanascimento = DateTime.Parse(Console.ReadLine());
            Repetir("=", 50);

            Clientes cl = new Clientes(wid, wnome, wdatanascimento);
            Pedidos ped = new Pedidos(DateTime.Now, 0, cl);

            Console.WriteLine("ENTRE COM OS DADOS DO PEDIDO");
            Repetir("=", 50);
            Console.WriteLine("");
            Console.Write("Quantos Itens o Pedido tem:");
            int wqtitens = int.Parse(Console.ReadLine());

            for (int i=0; i < wqtitens; i++)
            {

                Console.Write("Nome do Produto..........:");
                string wnomeproduto = Console.ReadLine();

                Console.Write("Preço do Produto.........:");
                double wprecoproduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Quantidade do Produto....:");
                int wquantproduto = int.Parse(Console.ReadLine());

                Produtos pr = new Produtos(wnomeproduto, wprecoproduto);

                Repetir("-", 50);

                ItensPedido ped2 = new ItensPedido(pr, wquantproduto, wprecoproduto);
                ped.AdicionaItem(ped2);

            }

            Console.WriteLine(ped.ToString());








        }
        static void Repetir(string caractere , int vezes)
        {
            for (int i=0; i <= vezes; i++)
            {
                Console.Write(caractere);
            }
            Console.WriteLine("");
        }
    }
}
