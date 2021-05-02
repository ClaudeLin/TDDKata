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
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Fifteen_Love()
        {
            expected = "Fifteen Love";
            tennisGame.ServicePlayerGetPoint();
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Fifteen_All()
        {
            expected = "Fifteen All";
            tennisGame.ServicePlayerGetPoint();
            tennisGame.ReceiverPlayerGetPoint();
            actual = tennisGame.GetCurrentScore();
            Assert.AreEqual(expected,actual);
        }
        
    }
}