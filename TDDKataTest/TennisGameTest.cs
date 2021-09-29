using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    [TestFixture]
    public class TennisGameTest
    {
        [Test]
        public void Love_All()
        {
            var expected = "Love ALl";
            var tennisGame = new TennisGame();
            var actual=tennisGame.CurrentScore();
            Assert.AreEqual(expected,actual);
        }
        
    }
}