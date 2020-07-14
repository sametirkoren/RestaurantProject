using Restaurant.DataAccess.Interfaces.Base;
using Restaurant.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        IRepository<TEntity> Dal<TEntity>() where TEntity : class, IEntity, new();
        bool HasChanges();
        void DetectChanges();
        bool Commit();

    }
}
