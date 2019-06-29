using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dismantle.Core.Specifications
{
    public class FilmPersonByFimIdPersonIdAndRole : ISpecification<FilmPerson>
    {
        public FilmPersonByFimIdPersonIdAndRole(int filmId, int personId, string role)
        {
            _filmId = filmId;
            _personId = personId;
            _role = role;
        }
        private int _filmId;
        private int _personId;
        private string _role;
        public Expression<Func<FilmPerson, bool>> Predicate => fp => (fp.FilmId == _filmId && fp.PersonId == _personId && fp.Role.Equals(_role));
    }
}
