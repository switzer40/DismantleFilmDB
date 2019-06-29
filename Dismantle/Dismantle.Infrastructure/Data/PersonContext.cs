using Dismantle.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Infrastructure.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions opts) : base(opts)
        {
        }
        public DbSet<Person> People { get; set; }
    }
}
