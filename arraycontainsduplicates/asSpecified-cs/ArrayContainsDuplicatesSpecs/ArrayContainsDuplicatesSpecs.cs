using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Katas
{
    [TestFixture]
    public class ArrayContainsDuplicatesSpecs
    {
        [Test]
        public void ArrayContainsDuplicates_DoesntContainDuplicates_ReturnsFalse() {
            Assert.Inconclusive();
        }

        [Test]
        public void ArrayContainsDuplicates_ContainsDuplicates_ReturnsTrue()
        {
            Assert.Inconclusive();
        }

        [Test]
        public void ArrayContainsDuplicates_ArrayIsEmpty_ReturnsFalse() {
            var anEmptyIntArray = new int[] {};
            var acd = new Katas.ArrayContainsDuplicates();
            var actualResult = acd.ContainsDuplicates(anEmptyIntArray);
            var expectedResult = true;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArrayontainsDuplicates_ArrayIsNull_ReturnsFalse()
        {
            var acd = new Katas.ArrayContainsDuplicates();
            var actualResult = acd.ContainsDuplicates(null);
            var expectedResult = true;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
