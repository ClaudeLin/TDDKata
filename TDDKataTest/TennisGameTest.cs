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

            actual = _tennisGame.Score();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Fifteen_Love()
        {
            expected = "Fifteen Love";

            _tennisGame.FirstPlayerGetScore();
            actual = _tennisGame.Score();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Fifteen_All()
        {
            expected = "Fifteen All";

            _tennisGame.FirstPlayerGetScore();
            _tennisGame.SecondPlayerGetScore();
            actual = _tennisGame.Score();
            
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Thirty_Love()
        {
            expected = "Thirty Love";
            
            _tennisGame.FirstPlayerGetScore();
            _tennisGame.FirstPlayerGetScore();
            actual = _tennisGame.Score();
            
            Assert.AreEqual(expected,actual);

        }
    }
}