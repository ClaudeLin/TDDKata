using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    public class TennisGameTest
    {
        private string expected;
        private TennisGame tennisGame;
        private string actual;

        [SetUp]
        public void SetUp()
        {
            tennisGame = new TennisGame();
        }

        [Test]
        public void Love_All()
        {
            expected = "Love All";
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Fifteen_Love()
        {
            expected = "Fifteen Love";
            tennisGame.ServicePlayerGetPoint();
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Fifteen_All()
        {
            expected = "Fifteen All";
            tennisGame.ServicePlayerGetPoint();
            tennisGame.ReceiverPlayerGetPoint();
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Thirty_Love()
        {
            expected = "Thirty Love";
            tennisGame.ServicePlayerGetPoint(2);
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Forty_Love()
        {
            expected = "Forty Love";
            tennisGame.ServicePlayerGetPoint(3);
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Thirty_Fifteen()
        {
            expected = "Thirty Fifteen";
            tennisGame.ServicePlayerGetPoint(2);
            tennisGame.ReceiverPlayerGetPoint();
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Deuce()
        {
            expected = "Deuce";
            tennisGame.ServicePlayerGetPoint(3);
            tennisGame.ReceiverPlayerGetPoint(3);
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void ServicePlayer_Adv()
        {
            expected = "Service Player Adv.";
            tennisGame.ServicePlayerGetPoint(3);
            tennisGame.ReceiverPlayerGetPoint(3);
            tennisGame.ServicePlayerGetPoint();
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void ReceiverPlayer_Adv_Then_BackToDeuce_Finally_ServicePlayer_Adv()
        {
            expected = "Service Player Adv.";
            tennisGame.ServicePlayerGetPoint(3);
            tennisGame.ReceiverPlayerGetPoint(4);
            tennisGame.ServicePlayerGetPoint(4);
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected,actual);
        }
    }
}