using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Interfaces.Repositories
{
    public interface IRepositoryFactory
    {
        IFilmPersonRepository NewFilmPersonRepository();
        IFilmPersonRepository OldFilmPersonRepository();
        IFilmRepository NewFilmRepository();
        IFilmRepository OldFilmRepository();
        IMediumRepository NewMediumRepository();
        IMediumRepository OldMediumRepository();
        IPersonRepository NewPersonRepository();
        IPersonRepository OldPersonRepository();        
    }}
