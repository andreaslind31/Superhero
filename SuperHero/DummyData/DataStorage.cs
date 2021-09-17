using SuperHero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.DummyData
{
    public class DataStorage
    {
        public static List<SuperheroModel> ListOfHeroes = new List<SuperheroModel>();

        static DataStorage()
        {
            
            SuperheroModel superman = new SuperheroModel()
            { Age = 120, Name = "Superman", Alias = "Clark Kent", TypeOfHero = "Flying" , Weight = 90 };
            ListOfHeroes.Add(superman);
            SuperheroModel spiderman = new SuperheroModel()
            { Age = 35, Name = "Spiderman", Alias = "Peter Parker", TypeOfHero = "Spider mutated", Weight = 65 };
            ListOfHeroes.Add(spiderman);
            SuperheroModel aquaman = new SuperheroModel()
            { Age = 45, Name = "Aquaman", Alias = "Arthur Curry", TypeOfHero = "Swimming", Weight = 100 };
            ListOfHeroes.Add(aquaman);
            SuperheroModel wolverine = new SuperheroModel()
            { Age = 1200, Name = "Wolverine", Alias = "Logan", TypeOfHero = "Self healing", Weight = 95 };
            ListOfHeroes.Add(wolverine);
        }
       
    }
}
