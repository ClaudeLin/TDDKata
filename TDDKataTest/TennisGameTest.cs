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

        [Test]
        public void Fifteen_Love()
        {
            GivenServicePlayerPoint(1);
            CurrentScoreShouldBe("Fifteen Love");
        }

        [Test]
        public void Thirty_Love()
        {
            GivenServicePlayerPoint(2);
            CurrentScoreShouldBe("Thirty Love");
        }

        [Test]
        public void Forty_Love()
        {
            GivenServicePlayerPoint(3);
            CurrentScoreShouldBe("Forty Love");
        }

        [Test]
        public void Love_Fifteen()
        {
            GivenReceiverPlayerPoint(1);
            CurrentScoreShouldBe("Love Fifteen");
        }

        [Test]
        public void Love_Thirty()
        {
            GivenReceiverPlayerPoint(2);
            CurrentScoreShouldBe("Love Thirty");
        }

        private void GivenReceiverPlayerPoint(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.ReceiverPlayerGetPoint();
            }
        }

        private void GivenServicePlayerPoint(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennisGame.ServicePlayerGetPoint();
            }
        }

        private void CurrentScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.CurrentScore());
        }
    }
}