using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dismantle.Core.Specifications
{
    public class FilmByTitleAndYear : ISpecification<Film>
    {
        public FilmByTitleAndYear(string title, short year)
        {
            _title = title;
            _year = year;
        }
        private string _title;
        private short _year;
        public Expression<Func<Film, bool>> Predicate => f => f.Title == _title && f.Year == _year;
    }
}
