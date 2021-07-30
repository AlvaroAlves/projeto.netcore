using AngularDotnet.Dominio.Contratos;
using AngularDotnet.Dominio.Entidades;
using AngularDotnet.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(AngularDotnetContexto context) : base(context)
        {
        }
    }
}
