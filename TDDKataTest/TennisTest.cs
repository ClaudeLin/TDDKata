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

        private void GivenReceiverPlayerPoint(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.ReceiverPlayerGetPoint();
            }
        }

        private void GivenServicePlayerPoint(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.ServicePlayerGetPoint();
            }
        }

        private void CurrentScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.GetCurrentScore());
        }
    }
}