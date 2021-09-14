using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHero.Domain.Models;

namespace SuperHero.Pages.Superhero
{
    public class ListSuperheroesModel : PageModel
    {
        public List<SuperheroModel> SuperheroList { get; set; }
        public void OnGet()
        {
            this.SuperheroList = Data.DataStorage.listOfHeroes;
            
        }
    }
}
