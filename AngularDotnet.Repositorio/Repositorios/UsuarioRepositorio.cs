using AngularDotnet.Dominio.Contratos;
using AngularDotnet.Dominio.Entidades;
using AngularDotnet.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AngularDotnet.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(AngularDotnetContexto context) : base(context)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            return Context.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
