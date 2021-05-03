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
        public void Forty_Love()
        {
            GivenServiceScore(3);
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Forty Love");
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
            GivenReceiverScore(2);
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Love Thirty");
        }
        [Test]
        public void Love_Forty()
        {
            GivenReceiverScore(3);
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Love Forty");
        }

        [Test]
        public void Fifteen_All()
        {
            GivenServiceScore(1);
            GivenReceiverScore(1);
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Fifteen All");
        }
        [Test]
        public void Thirty_All()
        {
            GivenServiceScore(2);
            GivenReceiverScore(2);
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Thirty All");
        }
        
        [Test]
        public void Deuce()
        {
            GivenServiceScore(3);
            GivenReceiverScore(3);
            _actual = _tennisGame.CurrentScore();
            CurrentScoreShouldBe("Deuce");
        }



        private void GivenReceiverScore(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennisGame.ReceiverGetScore();
            }
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