using Dismantle.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Interfaces.Repositories
{
    public interface IFilmRepository : IRepository<Film>
    {
        void AddFilm(string title, short year, short length);
        Film GetByTitleAndYear(string title, short year);
        Film GetById(int id);
    }
}
