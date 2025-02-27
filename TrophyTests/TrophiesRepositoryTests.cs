using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trophy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trophy.Tests
{
    [TestClass()]
    public class TrophiesRepositoryTests
    {
        [TestMethod()]

        public void GetByIdTest()
        {
            TrophiesRepository repo = new TrophiesRepository();
            repo.Add(new Trophy { Id = 1, Competition = "World Cup", Year = 2018 });
            repo.Add(new Trophy { Id = 2, Competition = "Olympics", Year = 2020 });
            repo.Add(new Trophy { Id = 3, Competition = "World Cup", Year = 2014 });
            repo.Add(new Trophy { Id = 4, Competition = "Olympics", Year = 2016 });
            repo.Add(new Trophy { Id = 5, Competition = "World Cup", Year = 2010 });

            Trophy result = repo.GetById(500);

            Trophy trophy = repo.GetById(1);
            Assert.AreEqual(1, trophy.Id);
            Assert.IsNull(result, "should return null when the ID is nonexistant");
        }







        [TestMethod()]
        public void AddTest()
        {
            TrophiesRepository repo = new TrophiesRepository();
            Trophy trophy = new Trophy { Id = 1, Competition = "World Cup", Year = 2018 };
            repo.Add(trophy);
            Assert.AreEqual(1, trophy.Id);
        }



        [TestMethod()]
        public void RemoveTest()
        {
            TrophiesRepository repo = new TrophiesRepository();
            repo.Add(new Trophy { Id = 1, Competition = "World Cup", Year = 2018 });
            repo.Add(new Trophy { Id = 2, Competition = "Olympics", Year = 2020 });
            repo.Add(new Trophy { Id = 3, Competition = "World Cup", Year = 2014 });
            repo.Add(new Trophy { Id = 4, Competition = "Olympics", Year = 2016 });
            repo.Add(new Trophy { Id = 5, Competition = "World Cup", Year = 2010 });

            repo.Remove(1);
            Assert.IsNull(repo.GetById(1));
        }
    }
}