using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Interfaces.Extractors
{
    public interface IExtractorFactory
    {
        IFilmExtractor FilmExtractor();
        IFilmPersonExtractor FilmPersonExtractor();
        IMediumExtractor MediumExtractor();
        IPersonExtractor PersonExtractor();
    }
}
