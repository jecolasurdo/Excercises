using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Katas
{
    [TestFixture]
    public class IsHappyPrimeSpecs
    {
        [TestCase]
        public void IsHappyPrime_GivenHappyPrimes_ReturnsTrue() {
            Assert.Inconclusive();
        }

        [TestCase]
        public void IsHappyPrime_GivenNonPrimes_ReturnsFalseWithNoFurtherProcessing() {
            Assert.Inconclusive();
        }

        [TestCase]
        public void IsHappyPrime_GivenNonHappyPrimes_ReturnsFalse() {
            Assert.Inconclusive();
        }

        private static readonly Int64[] Primes =
        {
            3,
            7,
            31,
            127,
            8191,
            131071,
            524287,
            2147483647
        };

        [Test, TestCaseSource("Primes")]
        public void IsPrime_GivenAPrime_ReturnsTrue(Int64 aPrimeNumber) {
            var hp = new HappyPrimes();
            var actualResult = hp.IsPrime(aPrimeNumber);
            var expectedResult = true;
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase]
        public void IsPrime_GivenNonPrime_ReturnsFalse() {
            Assert.Inconclusive();
        }

    }
}
