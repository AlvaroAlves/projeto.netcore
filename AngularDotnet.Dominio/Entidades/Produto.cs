using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagemCritica("Nome de produto não informado");
            if (Preco <= 0)
                AdicionarMensagemCritica("O preço precisa ser informado");
        }
    }
}
