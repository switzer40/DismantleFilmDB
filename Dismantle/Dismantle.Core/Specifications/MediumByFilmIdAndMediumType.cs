using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dismantle.Core.Specifications
{
    public class MediumByFilmIdAndMediumType : ISpecification<Medium>
    {
        public MediumByFilmIdAndMediumType(int filmId, string mediumType)
        {
            _filmId = filmId;
            _mediumType = mediumType;
        }
        private int _filmId;
        private string _mediumType;
        public Expression<Func<Medium, bool>> Predicate => m => (m.FilmId == _filmId && m.MediumType.Equals(_mediumType));
    }
}
