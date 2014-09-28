using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using Microsoft.SqlServer.Server;
using NUnit.Framework;
using Katas;

namespace Katas
{
    [TestFixture]
    public class WrapSpecs
    {
        [Test]
        public void Wrap_StringIsEmpty_ReturnsEmptyString() {
            Assert.Inconclusive();
        }

        [Test]
        public void Wrap_ColumnNumberIsNegative_ThrowsArgumentException() {
            var negativeColumnNumber = -1;
            var unimportantString = "Some Text";
            Assert.Throws<ArgumentOutOfRangeException>(() => Wrapper.Wrap(unimportantString, negativeColumnNumber));
        }

        [Test]
        public void Wrap_ColumnNumberIsZero_ReturnsOriginalTextValue() {
            var zeroColumn = 0;
            var someStringValue = "Some Text";

            var expectedResult = someStringValue;
            var actualResult = Wrapper.Wrap(someStringValue, zeroColumn);

            Assert.AreEqual(expectedResult,actualResult);
        }

        [Test]
        public void Wrap_SuppliedWithTabsOnly_TreatsTabsAsWhiteSpace() {
            var columnNumber = 10;
            var aBunchOfTabs = new string('\t', 4);

            var expectedResult = string.Empty;
            var actualResult = Wrapper.Wrap(aBunchOfTabs, 10);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(10)]
        public void Wrap_SuppliedWithBlankSpaces_ReturnsEmptyStringForAnyColumnValue(int columnNumber) {
            var fourConsecutiveSpaces = new string(' ', 4);

            var expectedResult = "";
            var actualResult = Wrapper.Wrap(fourConsecutiveSpaces, columnNumber);

            Assert.AreEqual(expectedResult,actualResult);
        }


        /// <summary>
        /// The essense of this specification is that if the column number is set 
        /// to a small value such as 2, words that are longer than 2 are allowed 
        /// to remain intact.
        /// </summary>
        [Test]
        public void Wrap_ColumnNumberIsLessThanLengthOfWord_BreaksAtWord() {
            Assert.Inconclusive();
        }

        [Test]
        public void Wrap_ColumnNumberGreaterThanTextLength_BreaksAtWord() {
            Assert.Inconclusive();    
        }

        [Test]
        public void Wrap_TextContainsLeadingSpaces_TruncatesLeadingSpaces() {
            Assert.Inconclusive();
        }

        /// <summary>
        /// Take the following sentance where dashes respresent spaces:
        ///    This-is-an-----amazing-test.
        /// This would be interpreted as follows:
        ///    This-is-an-----amazing/ntest.
        /// </summary>
        [Test]
        public void Wrap_ConsecutiveSpacesMidString_ConsecutiveSpacesAreRespected() {
            Assert.Inconclusive();
        }

        /// <summary>
        /// Take the following sentance where dashes respresent spaces:
        ///    This-is-an-amazing-test.---
        /// This would be interpreted as follows:
        ///    This-is-an-amazing-test.
        /// </summary>
        [Test]
        public void Wrap_WithTrailingSpace_TruncatesTrailingSpace() {
            Assert.Inconclusive();
        }

        /// <summary>
        /// Take the following sentance where dashes respresent spaces:
        ///    This-is-an-amazing-------test.
        /// This would be interpreted as follows:
        ///    This-is-an-amazing\ntest.
        /// </summary>
        [Test]
        public void Wrap_MultipleSpaceCharacters_RemainingSpaceCharactersAreTruncated() {
            Assert.Inconclusive();
        }
    }
}
