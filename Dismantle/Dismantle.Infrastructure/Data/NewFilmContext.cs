using Dismantle.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Infrastructure.Data
{
    public class NewFilmContext : DbContext
    {
        public NewFilmContext(DbContextOptions opts) : base(opts)
        {
        }
        public DbSet<Film> Films { get; set; }
    }
}
