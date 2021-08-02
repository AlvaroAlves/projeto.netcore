using AngularDotnet.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
    }
}
