using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Interfaces.General
{
    public interface ICopyable
    {
        void Copy(ICopyable arg);
        bool Equals(ICopyable other);
    }
}
