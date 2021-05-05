using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    public class TennisTest
    {
        private Tennis _tennis;

        [SetUp]
        public void SetUp()
        {
            _tennis = new Tennis();
        }
        [Test]
        public void Love_All()
        {
            CurrentScoreShouldBe("Love All");
        }

        [Test]
        public void Fifteen_Love()
        {
            _tennis.ServicePlayerGetPoint();
            CurrentScoreShouldBe("Fifteen Love");
        }

        private void CurrentScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.GetCurrentScore());
        }
    }
}