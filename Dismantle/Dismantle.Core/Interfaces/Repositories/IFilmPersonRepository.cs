using Dismantle.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Interfaces.Repositories
{
    public interface IFilmPersonRepository : IRepository<FilmPerson>
    {
        void AddFilmPerson(string title, short year, string lastName, string birthdate, string role);
        FilmPerson GetByTitleYearLastNameBirthdateAndRole(string title, short year, string lastName, string birthdate, string role);
    }
}
