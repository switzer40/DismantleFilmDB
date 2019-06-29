using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Interfaces.Extractors
{
    public interface IExtractor<T> where T : BaseEntity
    {        
        void ExtractAll();
    }
}
