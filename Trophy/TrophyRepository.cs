using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Trophy
{
    public class TrophiesRepository
    {
        private List<Trophy> trophies;


        public TrophiesRepository()
        {
            trophies = new List<Trophy>
            {
                new Trophy { Id = 1, Competition = "World Cup", Year = 2022 },
                new Trophy { Id = 2, Competition = "World Cup", Year = 2018 },
                new Trophy { Id = 3, Competition = "World Cup", Year = 2014 },
                new Trophy { Id = 4, Competition = "World Cup", Year = 2010 },
                new Trophy { Id = 5, Competition = "World Cup", Year = 2006 },

            };

        }

        public List<Trophy> GetTrophies(int? year = null, string? sortBy = null)
        {
            var copyList = new List<Trophy>(trophies);
            var result = copyList;
            if (year != null)
            {
                result = result.FindAll(t => t.Year == year);
            }
            if (sortBy != null)
            {
                if (sortBy == "year")
                {
                    result.Sort((t1, t2) => t1.Year.CompareTo(t2.Year));
                }
                else if (sortBy == "competition")
                {
                    result.Sort((t1, t2) => t1.Competition.CompareTo(t2.Competition));
                }
            }
            return result;
        }

        public List<Trophy> Get()
        {
            return new List<Trophy>(trophies);
        }

        public List<Trophy> Get(int year)
        {
            return trophies.Where(t => t.Year == year).ToList();
        }

   
        public Trophy GetById(int id)
        {
            return trophies.FirstOrDefault(t => t.Id == id);
        }


        public Trophy Add(Trophy trophy)
        {

            if (trophy.Id == 0)
            {
                trophy.Id = trophies.Max(t => t.Id) + 1;
            }

            trophies.Add(trophy);
            return trophy;
        }

        public Trophy Remove(int id)
        {
            var trophy = GetById(id);
            if (trophy != null)
            {
                trophies.Remove(trophy);
            }

            return trophy;
        }

        public Trophy Update(int id, Trophy trophy)
        {
            var existingTrophy = GetById(id);
            if (existingTrophy != null)
            {
                existingTrophy.Competition = trophy.Competition;
                existingTrophy.Year = trophy.Year;
            }

            return existingTrophy;
        }





    }
}
