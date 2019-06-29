using Dismantle.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Interfaces.Repositories
{
    public interface IMediumRepository : IRepository<Medium>
    {
        void AddMedium(string title, short year, string mediumType, string location, bool german);
        Medium GetByTitleYearAndMediumType(string title, short year, string mediumType);
    }
}
