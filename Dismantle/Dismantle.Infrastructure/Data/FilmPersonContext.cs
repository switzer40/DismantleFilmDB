using Dismantle.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Infrastructure.Data
{
    public class FilmPersonContext : DbContext
    {
        public FilmPersonContext(DbContextOptions opts) : base(opts)
        {
        }
        public DbSet<FilmPerson> FilmPeople { get; set; }
    }
}
