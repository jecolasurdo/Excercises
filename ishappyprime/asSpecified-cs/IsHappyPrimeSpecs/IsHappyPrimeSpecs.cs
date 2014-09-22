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

        private static readonly int[] Primes =
        {
            2,
            3,
            7,
            31,
            127,
            8191,
            131071,
            524287,
            2147483629
        };

        private static readonly int[] NonPrimes =
        {
            -1,
            -3,
            1,
            4,
            8,
            32,
            75,
            88
        };

        [Test, TestCaseSource("Primes")]
        public void IsPrime_GivenAPrime_ReturnsTrue(int aPrimeNumber) {
            var hp = new HappyPrimes();
            var actualResult = hp.IsPrime(aPrimeNumber);
            var expectedResult = true;
            Assert.AreEqual(expectedResult,actualResult);
        }

        [Test, TestCaseSource("NonPrimes")] 
        public void IsPrime_GivenNonPrime_ReturnsFalse(int notAPrimeNumber) {
            var hp = new HappyPrimes();
            var actualResult = hp.IsPrime(notAPrimeNumber);
            var expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsPrime_GivenZero_ThrowsException() {
            var hp = new HappyPrimes();
            Assert.Throws<ArithmeticException>(() => hp.IsPrime(0));
        }
    }
}
