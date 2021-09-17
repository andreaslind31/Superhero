using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHero.Domain.Models;

namespace SuperHero.Pages.Superhero
{
    public class EditSuperheroModel : PageModel
    {
        [BindProperty]
        public SuperheroModel Superhero { get; set; } = new SuperheroModel();

        public string Name { get; set; }
        public void OnGet(string name)
        {
            Name = name;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //sök genom LINQ för att hitta den specifika superheroen i listan
            //Data.DataStorage.listOfHeroes.Add(Superhero);

            return RedirectToPage("/Index",
                new
                {
                    SuperheroName = Superhero.Name,
                    SuperheroAge = Superhero.Age,
                    SuperheroType = Superhero.TypeOfHero,
                    SuperheroWeight = Superhero.Weight,
                    SuperheroAlias = Superhero.Alias
                });
        }
    }
}
