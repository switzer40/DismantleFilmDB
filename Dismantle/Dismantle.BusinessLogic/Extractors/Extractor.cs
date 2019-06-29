using Dismantle.Core.Interfaces.Extractors;
using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Core.SharedKernel;
using Dismantle.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.BusinessLogic.Extractors
{
    public abstract class Extractor<T> : IExtractor<T> where T : BaseEntity
    {
        protected IRepositoryFactory _repofact;
        protected IRepository<T> _oldRepo;
        protected IRepository<T> _newRepo;
        void IExtractor<T>.ExtractAll()
        {
            _oldRepo = SpecificOldRepo();
            _newRepo = SpecificNewRepo();
            foreach (var item in _oldRepo.List())
            {
                _newRepo.Add(item);
            }


        }

        protected abstract T SpecificEntity(T t);
        protected abstract IRepository<T> SpecificNewRepo();
        protected abstract IRepository<T> SpecificOldRepo();
    }
}
