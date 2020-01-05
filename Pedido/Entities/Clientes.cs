using System;

namespace Pedido.Entities
{
    class Clientes
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
 
        public Clientes()
        {

        }

        public Clientes(int iD, string nome, DateTime nascimento)
        {
            ID = iD;
            Nome = nome;
            Nascimento = nascimento;
        }


        public override string ToString()
        {
            return ID
                + ","
                + Nome
                + ","
                + Nascimento.ToString("dd/MM/yyyy");
              
        }


    }
}
