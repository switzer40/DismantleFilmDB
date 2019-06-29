using Dismantle.Core.Interfaces.Extractors;
using Dismantle.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.BusinessLogic.Extractors
{
    public class ExtractorFactory : IExtractorFactory
    {
        private readonly IRepositoryFactory _repofact;
        public ExtractorFactory(IRepositoryFactory repofact)
        {
            _repofact = repofact;
        }
        public IFilmExtractor FilmExtractor()
        {
            return new FilmExtractor(_repofact);
        }

        public IFilmPersonExtractor FilmPersonExtractor()
        {
            return new FilmPersonExtractor(_repofact);
        }

        public IMediumExtractor MediumExtractor()
        {
            return new MediumExtractor(_repofact);
        }

        public IPersonExtractor PersonExtractor()
        {
            return new PersonExtractor(_repofact);
        }
    }
}
