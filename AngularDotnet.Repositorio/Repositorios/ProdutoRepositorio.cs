using AngularDotnet.Dominio.Contratos;
using AngularDotnet.Dominio.Entidades;
using AngularDotnet.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(AngularDotnetContexto context) : base(context)
        {
        }
    }
}
