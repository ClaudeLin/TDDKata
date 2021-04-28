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
            string actual=tennisGame.Score();
            Assert.AreEqual("Love All",actual);
        }
    }
}