using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Infrastructure.Repositories
{
    public class OldMediumRepository : MediumRepository
    {
        public OldMediumRepository(OldFilmContext context, IFilmRepository frepo) : base(context, frepo)
        {
        }
    }
}
