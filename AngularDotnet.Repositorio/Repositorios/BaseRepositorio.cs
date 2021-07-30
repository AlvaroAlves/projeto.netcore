using AngularDotnet.Dominio.Contratos;
using AngularDotnet.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngularDotnet.Repositorio.Repositorios
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        //deve ser acessado pelas classes filhas
        protected readonly AngularDotnetContexto Context;

        //mapeada a instancia definida no startup
        public BaseRepositorio(AngularDotnetContexto context)
        {
            Context = context;
        }
        public void Adicionar(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Atualizar(T entity)
        {
            Context.Set<T>().Update(entity);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public T ObterPorId(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return Context.Set<T>().ToList();
        }

        public void Remover(T entity)
        {
            Context.Remove(entity);
            Context.SaveChanges();
        }
    }
}
