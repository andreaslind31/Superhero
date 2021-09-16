using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Domain.Models
{
    public class SuperheroModel
    {
        [BindProperty(SupportsGet = true)]
        [Required]
        public string Name { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Alias { get; set; }

        [BindProperty(SupportsGet = true)]
        [Required]
        public int Id { get; set; }

        [BindProperty(SupportsGet = true)]
        [Required]
        public int Age { get; set; }

        [BindProperty(SupportsGet = true)]
        [Required]
        public int Weight { get; set; }

        [BindProperty(SupportsGet = true)]
        [Required]
        public string TypeOfHero { get; set; }
    }
}
