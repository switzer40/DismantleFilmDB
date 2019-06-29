using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Core.Specifications;
using Dismantle.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dismantle.Infrastructure.Repositories
{
    public class NewFilmRepository : FilmRepository, INewFilmRepository   {
        public NewFilmRepository(NewFilmContext context): base(context)
        {
        }       
    }
}
