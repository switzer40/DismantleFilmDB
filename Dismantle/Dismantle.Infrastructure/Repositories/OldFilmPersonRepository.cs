using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Infrastructure.Data;
using Dismantle.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Infrastructure.Repositories
{
    public class OldFilmPersonRepository : FilmPersonRepository
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IPersonRepository _personRepository;
        public OldFilmPersonRepository(OldFilmContext context, IFilmRepository frepo, IPersonRepository prepo) : base(context, frepo, prepo)
        {            
        }

    }
}
