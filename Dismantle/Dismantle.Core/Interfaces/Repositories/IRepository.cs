using Dismantle.Core.Interfaces.Specifications;
using Dismantle.Core.SharedKernel;
using Dismantle.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dismantle.Core.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {        
        void Add(T t);        
        List<T> List();
        List<T> List(Expression<Func<T, bool>> predicate);
        List<T> List(ISpecification<T> specification);
    }
}
