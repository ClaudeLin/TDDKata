﻿using NUnit.Framework;
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
            expected = "Love ALl";
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
    }
}