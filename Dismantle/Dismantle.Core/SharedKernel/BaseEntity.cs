using Dismantle.Core.Interfaces.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.SharedKernel
{
    public abstract class BaseEntity : ISearchableBaseDto
    {
        public int Id { get; set; }
        public abstract void Copy(BaseEntity other);
        public abstract bool Equals(BaseEntity other);
        public abstract bool Search(string searchString);
    }
}
