using System;
using System.Collections.Generic;
using System.Globalization;
using Pedido.Entities.Enums;
using Pedido.Entities;
using System.Text;

namespace Pedido.Entities
{
    class Pedidos
    {
        public DateTime Data { get; set; }
        public StatusdoPedido Status { get; set; }
        public Clientes Cliente { get; set; }
        public List<ItensPedido> Itens { get; set; } = new List<ItensPedido>();

        public Pedidos()
        {

        }

        public Pedidos(DateTime data, StatusdoPedido status, Clientes cliente)
        {
            Data = data;
            Status = status;
            Cliente = cliente;
        }


        public void AdicionaItem(ItensPedido itens)
        {
            Itens.Add(itens);
        }

        public void RemoveItem(ItensPedido itens)
        {
            Itens.Remove(itens);
        }

        public double Total()
        {
            double soma = 0;
            foreach(ItensPedido it in Itens)
            {
                soma += it.SubTotal();
            }

            return soma;

        }



        public override string ToString()
        {

            StringBuilder st = new StringBuilder();

            st.AppendLine("RESUMO DO PEDIDO:");
            st.AppendLine("Momento do Pedido:" + Data.ToString("dd/MM/yyyy HH:mm:ss"));
            st.AppendLine("Status do Pedido.:" + Status);
            st.AppendLine("Cliente..........:" + Cliente);
            st.AppendLine("--- << ITENS DO PEDIDO >> ---");

            foreach(ItensPedido it in Itens)
            {
                st.AppendLine(it.ToString());
            }

            st.AppendLine("Preço Total do Pedido:" + Total().ToString("C", CultureInfo.CurrentCulture));

            return st.ToString();
        }


    }
}
