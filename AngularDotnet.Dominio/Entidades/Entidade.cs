using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngularDotnet.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao { 
            get 
            {
                return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());
            } 
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get 
            {
                return (!mensagemValidacao.Any());
            }
        }

        protected void AdicionarMensagemCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }
    }
}
