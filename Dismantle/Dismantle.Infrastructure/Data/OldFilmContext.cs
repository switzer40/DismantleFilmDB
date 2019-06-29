﻿using Dismantle.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Infrastructure.Data
{
    public class OldFilmContext : DbContext
    {
        public OldFilmContext(DbContextOptions opts) :base(opts)
        {
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmPerson> FilmPeople { get; set; }
        public DbSet<Medium> Media { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
