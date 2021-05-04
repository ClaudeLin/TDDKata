using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    public class TennisGameTest
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void SetUp()
        {
            _tennisGame = new TennisGame();
        }

        [Test]
        public void Love_All()
        {
            CurrentScoreShouldBe("Love All");
        }

        private void CurrentScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.CurrentScore());
        }
    }
}