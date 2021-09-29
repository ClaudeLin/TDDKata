using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    [TestFixture]
    public class TennisGameTest
    {[Test]
             public void Love_All()
             {
                 var expected = "Love ALl";
                 var tennisGame = new TennisGame();
                 var actual=tennisGame.CurrentScore();
                 Assert.AreEqual(expected,actual);
             }
             
        [Test]
        public void Fifteen_Love()
        {
            var expected = "Fifteen Love";
            var tennisGame = new TennisGame();
            tennisGame.ServiceGetPoint();
            var actual=tennisGame.CurrentScore();
            Assert.AreEqual(expected,actual);
        }
        
        
    }
}