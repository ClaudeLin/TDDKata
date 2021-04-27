using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    public class TennisGameTest
    {
        [Test]
        public void Love_All()
        {
            var tennisGame = new TennisGame();
            var actual = tennisGame.Score();
            Assert.AreEqual("Love All",actual);
        }

        [Test]
        public void Fifteen_Love()
        {
            var tennisGame = new TennisGame();
            tennisGame.FirstPlayerGetScore();
            var actual = tennisGame.Score();
            Assert.AreEqual("Fifteen Love",actual);
        }
        
    }
}