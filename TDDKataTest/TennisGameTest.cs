using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    public class TennisGameTest
    {
        private string _expected;
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
            _expected = "Love All";
            _actual = _tennisGame.GetCurrentScore();
            Assert.AreEqual(_expected,_actual);
        }
        
    }
}