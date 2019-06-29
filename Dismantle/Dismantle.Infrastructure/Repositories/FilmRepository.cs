using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Core.Interfaces.Specifications;
using Dismantle.Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dismantle.Infrastructure.Repositories
{
    public class FilmRepository : Repository<Film>, IFilmRepository
    {
        public FilmRepository(DbContext context) : base(context)
        {
        }
        public void AddFilm(string title, short year, short length)
        {
            // Avoid duplicates
            if (GetByTitleAndYear(title, year) == null)
            {
                Film f = new Film(title, year, length);
                Add(f);
            }
        }

        public Film GetById(int id)
        {
            var spec = new FilmById(id);
            return List(spec).FirstOrDefault();
        }

        public Film GetByTitleAndYear(string title, short year)
        {
            var spec = new FilmByTitleAndYear(title, year);
            return List(spec).FirstOrDefault();
        }
    }
}
