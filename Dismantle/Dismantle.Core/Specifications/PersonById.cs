using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dismantle.Core.Specifications
{
    public class PersonById : ISpecification<Person>
    {
        public PersonById(int id)
        {
            _id = id;
        }
        private int _id;
        public Expression<Func<Person, bool>> Predicate => p => p.Id == _id;
    }
}
