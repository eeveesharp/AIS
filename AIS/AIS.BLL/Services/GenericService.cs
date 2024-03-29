﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AIS.BLL.Interfaces.Services;
using AIS.DAL.Interfaces.Repositories;
using AutoMapper;

namespace AIS.BLL.Services
{
    public class GenericService<TEntity, TMapToEntity> : IGenericService<TEntity>
        where TEntity : class
        where TMapToEntity : class
    {
        private readonly IGenericRepository<TMapToEntity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<TMapToEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public virtual async Task<TEntity> Add(TEntity entity, CancellationToken ct)
        {
            return _mapper.Map<TEntity>(await _repository.Add(
                _mapper.Map<TMapToEntity>(entity), ct
            ));
        }

        public Task Delete(TEntity entity, CancellationToken ct)
        {
            return _repository.Delete(_mapper.Map<TMapToEntity>(entity), ct);
        }

        public Task Delete(int id, CancellationToken ct)
        {
            return _repository.Delete(id, ct);
        }

        public async Task<TEntity> Put(TEntity entity, CancellationToken ct)
        {
            return _mapper.Map<TEntity>(
                await _repository.Update(_mapper.Map<TMapToEntity>(entity), ct)
                );
        }

        public async Task<IEnumerable<TEntity>> Get(CancellationToken ct)
        {
            var result = _mapper.Map<IEnumerable<TEntity>>(
                await _repository.Get(ct)
            );

            return result;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, CancellationToken ct)
        {
            var result = _mapper.Map<IEnumerable<TEntity>>(
                this._repository.Get(_mapper.Map<Expression<Func<TMapToEntity, bool>>>(predicate), ct)
                );

            return result;
        }

        public async Task<TEntity> GetById(int id, CancellationToken ct)
        {
            var res = _mapper.Map<TEntity>(await _repository.GetById(id, ct));

            return res;
        }
    }
}