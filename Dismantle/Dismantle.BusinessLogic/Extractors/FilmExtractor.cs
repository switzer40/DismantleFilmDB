using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Extractors;
using Dismantle.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.BusinessLogic.Extractors
{
    public class FilmExtractor : Extractor<Film>, IFilmExtractor
    {
        public FilmExtractor(IRepositoryFactory repofact)
        {
            _repofact = repofact;
        }
        protected override Film SpecificEntity(Film t)
        {
            return t;
        }

        protected override IRepository<Film> SpecificNewRepo()
        {
            return _repofact.NewFilmRepository();
        }

        protected override IRepository<Film> SpecificOldRepo()
        {
            return _repofact.OldFilmRepository();
        }
    }
}
