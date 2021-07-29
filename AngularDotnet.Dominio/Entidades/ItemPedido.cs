using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarMensagemCritica("Não foi identificada a referência do produto");
            if (Quantidade == 0)
                AdicionarMensagemCritica("Quantidade de produto não informada");
        }
    }
}
