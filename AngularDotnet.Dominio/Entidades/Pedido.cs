using AngularDotnet.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado{ get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        /// <summary>
        /// Um pedido pode ter um ou muitos itens
        /// </summary>
        public ICollection<ItemPedido> ItemPedidos { get; set; }
    }
}
