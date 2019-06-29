using Dismantle.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Interfaces.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        void AddPerson(string lastName, string birthdate, string firstMidName);
        Person GetByLastNameAndBirthdate(string lastName, string birthdate);
        Person GetById(int id);
    }
}
