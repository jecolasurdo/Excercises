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
            var input1 = "AABCDE";
            var input2 = "EADBCA";
            var p = new Permutation();

            var actualResult = p.IsPermutationOfEachOther(input1, input2);
            var expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsPermutation_GivenANonPermutedCouple_ReturnsFalse() {
            var input1 = "AABCDE";
            var input2 = "EEDBCA";
            var p = new Permutation();

            var actualResult = p.IsPermutationOfEachOther(input1, input2);
            var expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsPermutation_Normally_IsCommutative() {
            var input1 = "AABCDE";
            var input2 = "EADBCA";
            var p = new Permutation();

            var actualResult = p.IsPermutationOfEachOther(input2, input1) == p.IsPermutationOfEachOther(input1, input2);
            var expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("AABCDE", "aABCDE", false)]
        [TestCase("aABCDE", "aABCDE", true)]
        public void IsPermutation_Normally_IsCaseSensitive(string input1,string input2, bool expectedResult) {
            var p = new Permutation();
            var actualResult = p.IsPermutationOfEachOther(input1, input2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsPermutation_GivenTwoEmptyStrings_ReturnsTrue() {
            var input1 = String.Empty;
            var input2 = String.Empty;
            var p = new Permutation();

            var actualResult = p.IsPermutationOfEachOther(input1, input2);
            var expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsPermutation_StringLengthsDiffer_ReturnsFalse() {
            var input1 = "AABCD";
            var input2 = "AABCDE";
            var p = new Permutation();

            var actualResult = p.IsPermutationOfEachOther(input1, input2);
            var expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("","ABCDE")]
        [TestCase("ABCDE","")]
        public void IsPermutation_GivenOneEmptyAndOneNonEmptyString_ReturnsFalse(string inputA, string inputB) {
            var p = new Permutation();

            var actualResult = p.IsPermutationOfEachOther(inputA, inputB);
            var expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
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
