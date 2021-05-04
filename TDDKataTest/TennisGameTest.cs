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
            _tennisGame = new TennisGame("Service");
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

        [Test]
        public void Love_Forty()
        {
            GivenReceiverPlayerPoint(3);
            CurrentScoreShouldBe("Love Forty");
        }

        [Test]
        public void Fifteen_All()
        {
            GivenReceiverPlayerPoint(1);
            GivenServicePlayerPoint(1);
            CurrentScoreShouldBe("Fifteen All");
        }

        [Test]
        public void Thirty_All()
        {
            GivenServicePlayerPoint(2);
            GivenReceiverPlayerPoint(2);
            CurrentScoreShouldBe("Thirty All");
        }

        [Test]
        public void Deuce()
        {
            GivenDeuce();
            CurrentScoreShouldBe("Deuce");
        }


        [Test]
        public void Service_Adv()
        {
            GivenDeuce();
            GivenServicePlayerPoint(1);
            CurrentScoreShouldBe("Service Adv");
        }

        private void GivenDeuce()
        {
            GivenServicePlayerPoint(3);
            GivenReceiverPlayerPoint(3);
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