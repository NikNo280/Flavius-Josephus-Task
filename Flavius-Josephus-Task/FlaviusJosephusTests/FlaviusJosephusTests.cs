using Flavius;
using FlaviusJosephusTests;
using NUnit.Framework;
using System;
using System.Linq;

namespace FlaviusJosephusTests
{
    public class FlaviusJosephusTests
    {
        [TestCase(20, 3, 20)]
        [TestCase(25, 2, 15)]
        [TestCase(3, 45, 1)]
        [TestCase(123, 45, 33)]
        public void СheckingCorrectTower(int n, int k, int last)
        {
            var flaviusJosephus = new FlaviusJosephus(n);
            var actual = flaviusJosephus.Effacement(k);
            Assert.AreEqual(actual.Last(), last);
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void NLessTnaOne(int n) => Assert.Throws<ArgumentException>(() => new FlaviusJosephus(n));
    }
}
