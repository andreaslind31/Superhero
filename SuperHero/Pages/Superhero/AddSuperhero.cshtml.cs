using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHero.Domain.Models;

namespace SuperHero.Pages.Superhero
{
    public class AddSuperheroModel : PageModel
    {
        [BindProperty]
        public SuperheroModel Superhero { get; set; } = new SuperheroModel();

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            Data.DataStorage.ListOfHeroes.Add(Superhero);

            return RedirectToPage("/Index",
                new {
                    SuperheroName = Superhero.Name,
                    SuperheroAge = Superhero.Age,
                    SuperheroType = Superhero.TypeOfHero,
                    SuperheroWeight = Superhero.Weight,
                    SuperheroAlias = Superhero.Alias
                });
        }
    }
}
