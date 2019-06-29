using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dismantle.Core.Specifications
{
    public class FilmById : ISpecification<Film>
    {
        public FilmById(int id)
        {
            _id = id;
        }
        private int _id;
        public Expression<Func<Film, bool>> Predicate => f => f.Id == _id;
    }
}
