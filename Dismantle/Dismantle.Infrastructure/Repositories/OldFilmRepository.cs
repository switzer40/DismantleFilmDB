using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Infrastructure.Repositories
{
    public class OldFilmRepository : FilmRepository, IOldFilmRepository
    {
        public OldFilmRepository(OldFilmContext context) : base(context)
        {
        }
    }
}
