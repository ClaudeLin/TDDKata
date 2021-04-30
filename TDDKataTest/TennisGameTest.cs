using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    public class TennisGameTest
    {
        private TennisGame _tennisGame;
        private string actual;
        private string expected;

        [SetUp]
        public void SetUp()
        {
            _tennisGame = new TennisGame();
        }

        [Test]
        public void Love_All()
        {
            expected = "Love All";

            actual = _tennisGame.GetScore();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Fifteen_Love()
        {
            expected = "Fifteen Love";

            _tennisGame.ServiceGetScore();
            actual = _tennisGame.GetScore();
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Fifteen_All()
        {
            expected = "Fifteen All";
            
            _tennisGame.ServiceGetScore();
            _tennisGame.ReceiverGetScore();
            actual = _tennisGame.GetScore();
            Assert.AreEqual(expected,actual);
        }
    }
}