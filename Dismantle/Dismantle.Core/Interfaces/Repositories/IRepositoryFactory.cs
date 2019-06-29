using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Interfaces.Repositories
{
    public interface IRepositoryFactory
    {
        IFilmPersonRepository NewFilmPersonRepository();
        IFilmPersonRepository OldFilmPersonRepository();
        INewFilmRepository NewFilmRepository();
        IOldFilmRepository OldFilmRepository();
        IMediumRepository NewMediumRepository();
        IMediumRepository OldMediumRepository();
        INewPersonRepository NewPersonRepository();
        IOldPersonRepository OldPersonRepository();
    }}
