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

            return RedirectToPage("/Index",
                new {
                    heroName = Superhero.Name, heroId = Superhero.Id, heroAge = Superhero.Age,
                    heroType = Superhero.TypeOfHero, heroWeight = Superhero.Weight 
                });
        }
    }
}
