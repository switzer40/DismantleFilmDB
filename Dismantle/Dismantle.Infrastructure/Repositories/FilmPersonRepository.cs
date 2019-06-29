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
    public class FilmPersonRepository : Repository<FilmPerson>, IFilmPersonRepository
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IPersonRepository _personRepository;

        public FilmPersonRepository(DbContext context, IFilmRepository frepo, IPersonRepository prepo) : base(context)
        {
            _filmRepository = frepo;
            _personRepository = prepo;
        }
        public void AddFilmPerson(string title, short year, string lastName, string birthdate, string role)
        {
            // Avoid duplicates
            if (GetByTitleYearLastNameBirthdateAndRole(title, year, lastName, birthdate, role) == null)
            {
                Film f = _filmRepository.GetByTitleAndYear(title, year);
                Person p = _personRepository.GetByLastNameAndBirthdate(lastName, birthdate);
                FilmPerson fp = new FilmPerson(f.Id, p.Id, role);
                Add(fp);
            }
        }

        public FilmPerson GetByTitleYearLastNameBirthdateAndRole(string title, short year, string lastName, string birthdate, string role)
        {
            Film f = _filmRepository.GetByTitleAndYear(title, year);
            Person p = _personRepository.GetByLastNameAndBirthdate(lastName, birthdate);
            var spec = new FilmPersonByFimIdPersonIdAndRole(f.Id, p.Id, role);
            return List(spec).FirstOrDefault();
        }
    }
}
