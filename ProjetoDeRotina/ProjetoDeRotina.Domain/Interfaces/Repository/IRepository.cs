using System;
using System.Collections.Generic;

namespace ProjetoDeRotina.Domain.Interfaces.Repository
{
    public interface IRepository <TEntity> : IDisposable where TEntity : class
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObtePorId(Guid id);
        IEnumerable<TEntity> ObterTodos();
        void Remover(Guid id);
        int SaveChanges();
    }
}
