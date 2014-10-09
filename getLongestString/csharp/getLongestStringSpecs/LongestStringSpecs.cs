using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Katas
{
    [TestFixture]
    public class LongestStringSpecs
    {
        public List<string> TestInputList = new List<string>
        {
            "Yuri",
            "Interview",
            "Nordstrom",
            "Cat",
            "Dog",
            "Telephone",
            "AVeryLongString",
            "This code puzzle is easy"
        };

        [Category("General")]
        [Test]
        public void GetLongestString_Normally_ReturnsTheLongestString() {
            var ls = new LongestString();
            var positionOfLongestString = 1;

            var expectedResult = "This code puzzle is easy";
            var actualResult = ls.GetNthLongestString(positionOfLongestString, TestInputList);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Category("General")]
        [Test]
        public void GetLongestString_Normally_ReturnsTheSpecifiedPosition()
        {
            var ls = new LongestString();
            var positionOfLongestString = 2;

            var expectedResult = "AVeryLongString";
            var actualResult = ls.GetNthLongestString(positionOfLongestString, TestInputList);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Category("Nth Arg Specs")]
        [Test]
        public void GetLongestString_GivenZero_ThrowsInvalidArgumentException() {
            var ls = new LongestString();
            var invalidNthValue = 0;
            Assert.Throws<ArgumentException>(() => ls.GetNthLongestString(invalidNthValue, TestInputList));
        }

        [Category("Nth Arg Specs")]
        [Test]
        public void GetLongestString_GivenNegative_ThrowsInvalidArgumentException() {
            Assert.Inconclusive();
        }

        [Category("Nth Arg Specs")]
        [Test]
        public void GetLongestString_GivenNumberGreaterThanListLength_ReturnsShortestWord() {
            var ls = new LongestString();
            var positionGreaterThanListLength = 20;

            var expectedResult = "Cat";
            var actualResult = ls.GetNthLongestString(positionGreaterThanListLength, TestInputList);

            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Assuming the following list:
        /// {"TT","FFFFF","SSSSSSS","GGGGG","IIIIII"}
        /// Both FFFFF and GGGGG are the 3rd longest.
        /// If nth = 3, the method should return FFFFF, as it is closer to the head of the list.
        /// 
        /// An alternative spec could be that the whichever is first alphanumerically is returned, but that
        /// doesn't seem as in keeping with the idea of exploring the positions within the list. This method
        /// also avoids the notion that alphanumeic sorting is applicable to list items' domain, which may
        /// not be a safe assumption.
        /// </summary>
        [Category("Nth Arg Specs")]
        [TestCase(4,"Interview")]
        [TestCase(8,"Cat")]
        public void GetLongestString_ItemsWithNLengthInMultiplePositions_ReturnsItemClosestToHeadOfList(int positionOfStringThatHasPartnersOfSameLength, string expectedResult)
        {
            var ls = new LongestString();

            var actualResult = ls.GetNthLongestString(positionOfStringThatHasPartnersOfSameLength, TestInputList);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Category("List Specs")]
        [Test]
        public void GetLongestString_ListIsEmpty_ThrowsInvalidArgumentException() {
            Assert.Inconclusive();
        }

        [Category("List Specs")]
        [Test]
        public void GetShortestString_ListIsNull_ThrowsInvalidArgumentException() {
            Assert.Inconclusive();
        }
    }
}
