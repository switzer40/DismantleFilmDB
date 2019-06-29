using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dismantle.Core.Interfaces.Extractors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dismantle.Web.Pages
{
    public class ExtractorModel : PageModel
    {
        private readonly IExtractorFactory _xfact;
        public ExtractorModel(IExtractorFactory xf)
        {
            _xfact = xf;
        }
        [BindProperty] public string Message { get; set; }
        public void OnGet()
        {
            IFilmExtractor filmExtractor = _xfact.FilmExtractor();
            IPersonExtractor personExtractor = _xfact.PersonExtractor();
            IMediumExtractor mediumExtractor = _xfact.MediumExtractor();
            IFilmPersonExtractor filmPersonExtractor = _xfact.FilmPersonExtractor();
            Message = "Extracting all films";
            filmExtractor.ExtractAll();
        }
    }
}