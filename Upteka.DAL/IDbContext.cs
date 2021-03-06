﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upteka.DAL
{
    public interface IDbContext : IDisposable
    {
        IEnumerable<DbEntityValidationResult> GetValidationErrors();

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbEntityEntry Entry(object entity);

        int SaveChanges();
    }
}
