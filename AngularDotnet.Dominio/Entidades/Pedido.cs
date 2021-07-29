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
        /// <summary>
        /// Um pedido pode ter um ou muitos itens
        /// </summary>
        public ICollection<ItemPedido> ItemPedidos { get; set; }
    }
}
