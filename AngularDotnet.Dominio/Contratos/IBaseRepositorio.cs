using System;
using System.Collections.Generic;
using System.Text;

namespace AngularDotnet.Dominio.Contratos
{
    //Definida interface que trabalhará somente com o tipo TEntity, que herda de outra interface IDisposable, informando que TEntity é uma classe
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}
