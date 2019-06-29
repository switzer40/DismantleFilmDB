using Dismantle.Core.Entities;
using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dismantle.Infrastructure.Repositories
{
    public class MediumRepository : Repository<Medium>, IMediumRepository
    {
        private readonly IFilmRepository _filmRepository;
        public MediumRepository(DbContext context,  IFilmRepository frepo) : base(context)
        {
            _filmRepository = frepo;
        }
        public void AddMedium(string title, short year, string mediumType, string location, bool german)
        {
            // Avoid duplicates
            if (GetByTitleYearAndMediumType(title, year, mediumType) == null)
            {
                Film f = _filmRepository.GetByTitleAndYear(title, year);
                Medium m = new Medium(f.Id, mediumType, location, german);
                Add(m);
            }
        }

        public Medium GetByTitleYearAndMediumType(string title, short year, string mediumType)
        {
            Film f = _filmRepository.GetByTitleAndYear(title, year);
            var spec =new  MediumByFilmIdAndMediumType(f.Id, mediumType);
            return List(spec).FirstOrDefault();
        }

    }
}
