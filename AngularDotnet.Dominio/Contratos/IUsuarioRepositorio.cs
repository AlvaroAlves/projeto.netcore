using AngularDotnet.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        //Já vai herdar as assinaturas da interface mãe
    }
}
