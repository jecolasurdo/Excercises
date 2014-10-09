using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using NUnit.Framework;

namespace Katas
{
    [TestFixture]
    public class PerumutationSpecs
    {
        [Test]
        public void IsPermutation_GivenAPermutedCouple_ReturnsTrue() {
            Assert.Inconclusive();
        }

        [Test]
        public void IsPermutation_GivenANonPermutedCouple_ReturnsFalse() {
            Assert.Inconclusive();
        }

        [Test]
        public void IsPermutation_GivenTwoEmptyStrings_ReturnsTrue() {
            Assert.Inconclusive();
        }

        [Test]
        public void IsPermutation_StringLengthsDiffer_ReturnsFalse() {
            Assert.Inconclusive();
        }

        [TestCase]
        [TestCase]
        public void IsPermutation_GivenOneEmptyAndOneNonEmptyString_ReturnsFalse(string inputA, string inputB) {
            Assert.Inconclusive();
        }

        [TestCase]
        [TestCase]
        [TestCase]
        public void IsPermutation_GivenNullsInAnyPosition_ThrowsNullArgumentException(string inputA, string inputB)
        {
            Assert.Inconclusive();
        }
    }
}
