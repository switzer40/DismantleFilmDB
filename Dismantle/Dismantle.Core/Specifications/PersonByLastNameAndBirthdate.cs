using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dismantle.Core.Specifications
{
    public class PersonByLastNameAndBirthdate : ISpecification<Person>
    {
        public PersonByLastNameAndBirthdate(string lastName, string birthdate)
        {
            _lastName = lastName;
            _birthdate = birthdate;
        }
        private string _lastName;
        private string _birthdate;
        public Expression<Func<Person, bool>> Predicate => p => (p.LastName.Equals(_lastName) && p.BirthdateString.Equals(_birthdate));
    }
}
