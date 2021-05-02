using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    public class TennisGameTest
    {
        [Test]
        public void Love_All()
        {
            var expected = "Love All";
            var tennisGame = new TennisGame();
            var actual=tennisGame.GetCurrentScore();
            Assert.AreEqual(expected,actual);
        }
        
    }
}