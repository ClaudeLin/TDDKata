using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    [TestFixture]
    public class TennisGameTest
    {
        [SetUp]
        public void SetUp()
        {
            tennisGame = new TennisGame();
        }

        private string expected;
        private TennisGame tennisGame;
        private string actual;

        [Test]
        public void Love_All()
        {
            expected = "Love All";
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Fifteen_Love()
        {
            expected = "Fifteen Love";
            tennisGame.ServiceGetPoint();
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Thirty_Love()
        {
            expected = "Thirty Love";
            tennisGame.ServiceGetPoint(2);
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Forty_Love()
        {
            expected = "Forty Love";
            tennisGame.ServiceGetPoint(3);
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Fifteen_All()
        {
            expected = "Fifteen All";
            tennisGame.ServiceGetPoint();
            tennisGame.ReceiverGetPoint();
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Thirty_All()
        {
            expected = "Thirty All";
            tennisGame.ServiceGetPoint(2);
            tennisGame.ReceiverGetPoint(2);
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Deuce()
        {
            expected = "Deuce";
            tennisGame.ServiceGetPoint(3);
            tennisGame.ReceiverGetPoint(3);
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Love_Fifteen()
        {
            expected = "Love Fifteen";
            tennisGame.ReceiverGetPoint();
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Love_Thirty()
        {
            expected = "Love Thirty";
            tennisGame.ReceiverGetPoint(2);
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Love_Forty()
        {
            expected = "Love Forty";
            tennisGame.ReceiverGetPoint(3);
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Service_Adv()
        {
            expected = "Service Adv";
            tennisGame.ServiceGetPoint(3);
            tennisGame.ReceiverGetPoint(3);
            tennisGame.ServiceGetPoint();
            actual = tennisGame.CurrentScore();
            Assert.AreEqual(expected, actual);
        }
    }
}