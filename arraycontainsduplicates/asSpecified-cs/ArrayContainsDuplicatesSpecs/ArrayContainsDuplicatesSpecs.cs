using NUnit.Framework;

namespace Katas
{
    [TestFixture]
    public class ArrayContainsDuplicatesSpecs
    {
        [Test]
        public void ArrayContainsDuplicates_DoesntContainDuplicates_ReturnsFalse() {
            var anArrayWithNoDuplicates = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var acd = new Katas.ArrayContainsDuplicates();
            var actualResult = acd.ContainsDuplicates(anArrayWithNoDuplicates);
            var expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArrayContainsDuplicates_ContainsDuplicates_ReturnsTrue()
        {
            var anArrayWithDuplicates = new int[] { 0, 1, 2, 2, 4, 5, 6, 7, 8, 9 };
            var acd = new Katas.ArrayContainsDuplicates();
            var actualResult = acd.ContainsDuplicates(anArrayWithDuplicates);
            var expectedResult = true;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArrayContainsDuplicates_ArrayIsEmpty_ReturnsFalse() {
            var anEmptyIntArray = new int[] {};
            var acd = new Katas.ArrayContainsDuplicates();
            var actualResult = acd.ContainsDuplicates(anEmptyIntArray);
            var expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArrayontainsDuplicates_ArrayIsNull_ReturnsFalse()
        {
            var acd = new Katas.ArrayContainsDuplicates();
            var actualResult = acd.ContainsDuplicates(null);
            var expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
