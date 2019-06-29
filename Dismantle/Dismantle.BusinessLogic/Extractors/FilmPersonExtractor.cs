using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Extractors;
using Dismantle.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.BusinessLogic.Extractors
{
    public class FilmPersonExtractor : Extractor<FilmPerson>, IFilmPersonExtractor
    {
        public FilmPersonExtractor(IRepositoryFactory repofact)
        {
            _repofact = repofact;
        }
        protected override FilmPerson SpecificEntity(FilmPerson t)
        {
            return t;
        }

        protected override IRepository<FilmPerson> SpecificNewRepo()
        {
            return _repofact.NewFilmPersonRepository();
        }

        protected override IRepository<FilmPerson> SpecificOldRepo()
        {
            return _repofact.OldFilmPersonRepository();
        }
    }
}
