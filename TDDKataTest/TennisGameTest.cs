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

        [Test]
        public void Fifteen_Love()
        {
            GivenServiceScore(1);
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Fifteen Love");
        }

        [Test]
        public void Thirty_Love()
        {
            GivenServiceScore(2);
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Thirty Love");
        }

        [Test]
        public void Love_Fifteen()
        {
            _tennisGame.ReceiverGetScore();
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Love Fifteen");
        }

        [Test]
        public void Love_Thirty()
        {
            _tennisGame.ReceiverGetScore();
            _tennisGame.ReceiverGetScore();
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Love Thirty");
        }

        private void GivenServiceScore(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennisGame.ServiceGetScore();
            }
        }

        private void CurrentScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _actual);
        }
    }
}