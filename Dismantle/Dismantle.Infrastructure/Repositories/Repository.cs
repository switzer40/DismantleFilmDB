using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Core.Interfaces.Specifications;
using Dismantle.Core.SharedKernel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dismantle.Infrastructure.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbContext _context;
        protected DbSet<T> _set;
        public Repository(DbContext context)
        {
            _context = context;
        }


        public void Add(T t)
        {
            _set.Add(t);
            Save();
        }

        private void Save()
        {
            _context.SaveChanges();
        }

        public List<T> List()
        {
            return _set.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> predicate)
        {
            List<T> result = new List<T>();
            var f = predicate.Compile();
            foreach (var item in List())
            {
                if (f(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<T> List(ISpecification<T> specification)
        {
            return List(specification.Predicate);
        }
    }
}
