using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dismantle.Infrastructure.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context) : base(context)
        {
        }
        public void AddPerson(string lastName, string birthdate, string firstMidName)
        {
            // Avoid duplicates
            if (GetByLastNameAndBirthdate(lastName, birthdate) == null)
            {
                Person p = new Person(lastName, birthdate, firstMidName);
                Add(p);
            }
        }

        public Person GetById(int id)
        {
            var spec = new PersonById(id);
            return List(spec).FirstOrDefault();
        }

        public Person GetByLastNameAndBirthdate(string lastName , string birthdate)
        {
            var spec = new PersonByLastNameAndBirthdate(lastName, birthdate);
            return List(spec).FirstOrDefault();
        }
    }
}
