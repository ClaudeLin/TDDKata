using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    public class TennisGameTest
    {
        private TennisGame _tennisGame;
        private string _actual;

        [SetUp]
        public void SetUp()
        {
            _tennisGame = new TennisGame();
        }
        [Test]
        public void Love_All()
        {
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Love All");
        }

        private void CurrentScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _actual);
        }
    }
}