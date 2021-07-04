using NUnit.Framework;
using TDDKata;

namespace TDDKataTest
{
    [TestFixture]
    public class TennisTest
    {

        [Test]
        public void Love_All()
        {
            var tennis = new Tennis();
            
            var actual = tennis.Score();

            var expected="Love All";
            Assert.AreEqual(expected,actual);

        }
    }
}