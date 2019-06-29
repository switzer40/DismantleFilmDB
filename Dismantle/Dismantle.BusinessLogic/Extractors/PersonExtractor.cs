using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Extractors;
using Dismantle.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.BusinessLogic.Extractors
{
    public class PersonExtractor : Extractor<Person>, IPersonExtractor
    {
        public PersonExtractor(IRepositoryFactory repofact)
        {
            _repofact = repofact;
        }
        protected override Person SpecificEntity(Person t)
        {
            return t;
        }

        protected override IRepository<Person> SpecificNewRepo()
        {
            return _repofact.NewPersonRepository();
        }

        protected override IRepository<Person> SpecificOldRepo()
        {
            return _repofact.OldPersonRepository();
        }
    }
}
