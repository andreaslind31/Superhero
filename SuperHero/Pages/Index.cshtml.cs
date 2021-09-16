using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SuperHero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string SuperheroName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SuperheroAlias { get; set; }

        [BindProperty(SupportsGet = true)]
        public int SuperheroId { get; set; }

        [BindProperty(SupportsGet = true)]
        public int SuperheroAge { get; set; }

        [BindProperty(SupportsGet = true)]
        public int SuperheroWeight { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SuperheroType { get; set; }

        public void OnGet()
        {

        }
    }
}
