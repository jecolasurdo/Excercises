using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;

namespace Katas
{
    [TestFixture]
    public class LongestStringSpecs
    {
        [Category("General")]
        [Test]
        public void GetLongestString_Normally_ReturnsTheLongestString() {
            Assert.Inconclusive();
        }

        [Category("Nth Arg Specs")]
        [Test]
        public void GetLongestString_GivenZero_ThrowsInvalidArgumentException() {
            Assert.Inconclusive();
        }

        [Category("Nth Arg Specs")]
        [Test]
        public void GetLongestString_GivenNegative_ThrowsInvalidArgumentException() {
            Assert.Inconclusive();
        }

        [Category("Nth Arg Specs")]
        [Test]
        public void GetLongestString_GivenNumberGreaterThanListLength_ReturnsLongestWord() {
            Assert.Inconclusive();
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
        [Test]
        public void GetLongestString_ItemsWithNLengthInMultiplePositions_ReturnsItemClosestToHeadOfList() {
            Assert.Inconclusive();
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
