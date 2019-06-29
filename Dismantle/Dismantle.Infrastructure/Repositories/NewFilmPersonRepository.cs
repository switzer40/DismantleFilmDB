using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Infrastructure.Repositories
{
    public  class NewFilmPersonRepository : FilmPersonRepository
    {
        public NewFilmPersonRepository(FilmPersonContext context, INewFilmRepository frepo, INewPersonRepository prepo) : base(context, frepo, prepo)
        {
        }
    }
}
