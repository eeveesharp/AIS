﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace AIS.BLL.Interfaces.Services
{
    public interface IGenericService<TEntity>
    {
        Task<TEntity> Add(TEntity entity, CancellationToken ct);
        Task<IEnumerable<TEntity>> Get(CancellationToken ct);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, CancellationToken ct);
        Task<TEntity> GetById(int id, CancellationToken ct);
        Task<TEntity> Put(TEntity entity, CancellationToken ct);
        Task Delete(TEntity entity, CancellationToken ct);
        Task Delete(int id, CancellationToken ct);
    }
}
