using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    public class TennisGameTest
    {
        private TennisGame _tennisGame;
        private string _actual;
        private string _expected;

        [SetUp]
        public void SetUp()
        {
            _tennisGame = new TennisGame();
        }

        [Test]
        public void Love_All()
        {
            _expected = "Love All";
            
            _actual = _tennisGame.Score();
            
            Assert.AreEqual(_expected,_actual);
        }

        [Test]
        public void Fifteen_Love()
        {
            _expected = "Fifteen Love";
            
            _tennisGame.FirstPlayerGetScore();
            _actual=_tennisGame.Score();
            
            Assert.AreEqual(_expected,_actual);

        }
    }
}