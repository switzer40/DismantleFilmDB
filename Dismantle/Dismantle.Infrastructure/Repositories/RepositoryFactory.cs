using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Infrastructure.Repositories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly OldFilmContext _oldFilmContext;
        private readonly NewFilmContext _newFilmContext;
        private readonly FilmPersonContext _filmPersonContext;
        private readonly MediumContext _mediumContext;
        private readonly PersonContext _personContext;
        public RepositoryFactory(OldFilmContext ofContext,
                                 NewFilmContext nfContext,
                                 FilmPersonContext fpContext,
                                 MediumContext mContext,
                                 PersonContext pContext)
        {
            _oldFilmContext = ofContext;
            _newFilmContext = nfContext;
            _filmPersonContext = fpContext;

            _mediumContext = mContext;
            _personContext = pContext;
        }

       
        public IFilmPersonRepository NewFilmPersonRepository()
        {
            return new NewFilmPersonRepository(_filmPersonContext, NewFilmRepository(), NewPersonRepository());
        }

        public INewFilmRepository NewFilmRepository()
        {
            return new NewFilmRepository(_newFilmContext);
        }

        public IMediumRepository NewMediumRepository()
        {
            return new NewMediumRepository(_mediumContext, NewFilmRepository());
        }

        public INewPersonRepository NewPersonRepository()
        {
            return new NewPersonRepository(_personContext);
        }

        public IFilmPersonRepository OldFilmPersonRepository()
        {
            return new OldFilmPersonRepository(_oldFilmContext, OldFilmRepository(), OldPersonRepository());
        }

        public IOldFilmRepository OldFilmRepository()
        {
            return new OldFilmRepository(_oldFilmContext);
        }

        public IMediumRepository OldMediumRepository()
        {
            return new OldMediumRepository(_oldFilmContext, OldFilmRepository());
        }

        public IOldPersonRepository OldPersonRepository()
        {
            return new OldPersonRepository(_oldFilmContext);
        }

        public IPersonRepository PersonRepository()
        {
            throw new NotImplementedException();
        }
    }
}
