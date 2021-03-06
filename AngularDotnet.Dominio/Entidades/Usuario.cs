using System.Collections;
using System.Collections.Generic;

namespace AngularDotnet.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarMensagemCritica("Email não informado!");
            if (string.IsNullOrEmpty(Senha))
                AdicionarMensagemCritica("Senha não informada!");

        }
    }
}
