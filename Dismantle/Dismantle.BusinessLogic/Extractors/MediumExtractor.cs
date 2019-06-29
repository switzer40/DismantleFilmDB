using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Extractors;
using Dismantle.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.BusinessLogic.Extractors
{
    public class MediumExtractor : Extractor<Medium>, IMediumExtractor
    {
        public MediumExtractor(IRepositoryFactory repofact)
        {
            _repofact = repofact;
        }
        protected override Medium SpecificEntity(Medium t)
        {
            return t;
        }

        protected override IRepository<Medium> SpecificNewRepo()
        {
            return _repofact.NewMediumRepository();
        }

        protected override IRepository<Medium> SpecificOldRepo()
        {
            return _repofact.OldMediumRepository();
        }
    }
}
