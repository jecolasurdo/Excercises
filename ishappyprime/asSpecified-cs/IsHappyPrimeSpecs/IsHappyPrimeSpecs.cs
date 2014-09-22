using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NSubstitute;

namespace Katas
{
    [TestFixture]
    public class IsHappyPrimeSpecs
    {
        /// <summary>
        /// Test primes are mercennes along with max 32bit prime.
        /// </summary>
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

        /// <summary>
        /// Test nonprimes include negatives, random composites, and large 32bit negative non-prime.
        /// Zero and One are special and should be handled in a separate specification.
        /// </summary>
        private static readonly int[] NonPrimes =
        {
            -1,
            -3,
            4,
            8,
            32,
            75,
            88,
            2147483627
        };

        /// <summary>
        /// List of happy primes from OEIS
        /// </summary>
        private static readonly int[] HappyPrimes =
        {
            7,
            13,
            19,
            23,
            397,
            409,
            487
        };

        /// <summary>
        /// List of unhappy primes from OEIS
        /// </summary>
        private static readonly int[] UnhappyPrimes =
        {
            2,
            3,
            47,
            311,
            347,
            389
        };

        [Test (Description = "Validate independant of the prime cherker that the happy number checker works.")]
        public void IsHappyPrime_GivenHappyNumberWithPrimeCheckerOverridden_ReturnsTrue() {
            Assert.Inconclusive();
        }

        [Test, TestCaseSource("HappyPrimes")]
        public void IsHappyPrime_GivenHappyPrimes_ReturnsTrue(int happyPrime) {
            var hp = new HappyPrimes();
            var actualResult = hp.IsHappyPrime(happyPrime);
            var expectedResult = true;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, TestCaseSource("UnhappyPrimes")]
        public void IsHappyPrime_GivenNonHappyPrimes_ReturnsFalse(int unhappyPrime) {
            var hp = new HappyPrimes();
            var actualResult = hp.IsHappyPrime(unhappyPrime);
            var expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsHappyPrime_GivenNonPrimes_ReturnsFalse()
        {
            var primeFaker = Substitute.For<IHappyPrimes>();
            var anyValue = 0;
            primeFaker.IsPrime(anyValue).ReturnsForAnyArgs(false);
            var hp = new HappyPrimes(primeFaker.IsPrime);
            var anyNonPrimeNumber = 4;
            var actualResult = hp.IsHappyPrime(anyNonPrimeNumber);
            var expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

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

        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_GivenInvalidNonComposite_ThrowsException(int invalidNonComposite) {
            var hp = new HappyPrimes();
            Assert.Throws<ArithmeticException>(() => hp.IsPrime(invalidNonComposite));
        }
    }
}
