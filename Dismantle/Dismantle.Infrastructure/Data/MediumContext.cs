using Dismantle.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Infrastructure.Data
{
    public class MediumContext : DbContext
    {
        public MediumContext(DbContextOptions opts) : base(opts)
        {
        }
        public DbSet<Medium> Media { get; set; }
    }
}
