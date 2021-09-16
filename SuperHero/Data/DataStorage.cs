using SuperHero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Data
{
    public class DataStorage
    {
        public static List<SuperheroModel> listOfHeroes = new List<SuperheroModel>();

        static DataStorage()
        {
            
            SuperheroModel superman = new SuperheroModel()
            { Age = 120, Id = 1, Name = "Superman", Alias = "Clark Kent", TypeOfHero = "Flying" , Weight = 90 };
            listOfHeroes.Add(superman);
            SuperheroModel spiderman = new SuperheroModel()
            { Age = 35, Id = 2, Name = "Spiderman", Alias = "Peter Parker", TypeOfHero = "Spider mutated", Weight = 65 };
            listOfHeroes.Add(spiderman);
            SuperheroModel aquaman = new SuperheroModel()
            { Age = 45, Id = 3, Name = "Aquaman", Alias = "Arthur Curry", TypeOfHero = "Swimming", Weight = 100 };
            listOfHeroes.Add(aquaman);
            SuperheroModel wolverine = new SuperheroModel()
            { Age = 1200, Id = 4, Name = "Wolverine", Alias = "Logan", TypeOfHero = "Self healing", Weight = 95 };
            listOfHeroes.Add(wolverine);
        }
       
    }
}
