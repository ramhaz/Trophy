using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trophy;
using System;

namespace Trophy.Tests
{
    [TestClass()]
    public class TrophyTests
    {
        [TestMethod()]
        public void TrophyIdTest()
        {
            // Test if setting Id to a valid value works
            Trophy trophy = new Trophy();
            trophy.Id = 1;
            Assert.AreEqual(1, trophy.Id);

            // Test if setting Id to a negative value throws exception
            Trophy trophy1 = new Trophy();
            Assert.ThrowsException<ArgumentException>(() => trophy1.Id = -1);
        }

        [TestMethod()]
        public void TrophyCompetitionTest()
        {
            // Test if valid competition name works
            Trophy trophy = new Trophy();
            trophy.Competition = "World Cup";
            Assert.AreEqual("World Cup", trophy.Competition);

            // test competition for at den ikke kan være mindre end 3 tegn
            Trophy trophy1 = new Trophy();
            Assert.ThrowsException<ArgumentException>(() => trophy1.Competition = "WC");

            // test hvis "null" throws exception of the competition
            Trophy trophy2 = new Trophy();
            Assert.ThrowsException<ArgumentException>(() => trophy2.Competition = null);

            // test hvis empty competition throws exception
            Trophy trophy3 = new Trophy();
            Assert.ThrowsException<ArgumentException>(() => trophy3.Competition = "");
        }

        [TestMethod()]
        public void TrophyYearTest()
        {
            // test hvis year er inde for året 
            Trophy trophy = new Trophy();
            trophy.Year = 2000;
            Assert.AreEqual(2000, trophy.Year);

            // test hvis year er mindre end året 1970
            Trophy trophy1 = new Trophy();
            Assert.ThrowsException<ArgumentException>(() => trophy1.Year = 1969);

            // Test hvis yea er større end året 2025
            Trophy trophy2 = new Trophy();
            Assert.ThrowsException<ArgumentException>(() => trophy2.Year = 2026);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //test toostringmethode 
            Trophy trophy = new Trophy();
            trophy.Id = 1;
            trophy.Competition = "Champions League";
            trophy.Year = 2021;
            Assert.AreEqual("Id: 1, Competition: Champions League, Year: 2021", trophy.ToString());
        }
    }
}
