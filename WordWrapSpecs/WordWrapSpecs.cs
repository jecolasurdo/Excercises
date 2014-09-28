using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
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
            var someColumnNumber = 10;
            var emptyString = string.Empty;

            var expectedResult = emptyString;
            var actualResult = Wrapper.Wrap(String.Empty, someColumnNumber);

            Assert.AreEqual(expectedResult, actualResult);
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
            var aColumnNumberLessThanWordLength = 2;
            var textToWrap = "aaa aaa  aaa";

            var expectedResult = "aaa\naaa\naaa";
            var actualResult = Wrapper.Wrap(textToWrap, aColumnNumberLessThanWordLength);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Wrap_Normally_BreaksAtWord() {
            var aColumnNumber = 10;
            var textToWrap = "aaa  aaa  aaa";

            var expectedResult = "aaa  aaa\naaa";
            var actualResult = Wrapper.Wrap(textToWrap, aColumnNumber);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Wrap_TextContainsLeadingSpaces_TruncatesLeadingSpaces() {
            var someColumnNumberThatWontInterfereWithTheTextValue = 100;
            var aStringWithLeadingSpaces = "    Hi Mom!";

            var expectedResult = "Hi Mom!";
            var actualResult = Wrapper.Wrap(aStringWithLeadingSpaces, someColumnNumberThatWontInterfereWithTheTextValue);

            Assert.AreEqual(expectedResult,actualResult);
        }

        /// <summary>
        /// Take the following sentance where dashes respresent spaces:
        ///    This-is-an-----amazing-test.
        /// This would be interpreted as follows:
        ///    This-is-an-----amazing/ntest.
        /// </summary>
        [Test]
        public void Wrap_ConsecutiveSpacesMidString_ConsecutiveSpacesAreRespected() {
            var columnNumber = 20;
            var aStringWithConsecutiveInternalSpaces = "Lorem     ipsum dolor sit amet";

            var expectedResult = "Lorem     ipsum\ndolor sit amet";
            var actualResult = Wrapper.Wrap(aStringWithConsecutiveInternalSpaces, columnNumber);

            Assert.AreEqual(expectedResult,actualResult);
        }

        /// <summary>
        /// Take the following sentance where dashes respresent spaces:
        ///    This-is-an-amazing-test.---
        /// This would be interpreted as follows:
        ///    This-is-an-amazing-test.
        /// </summary>
        [Test]
        public void Wrap_WithTrailingSpace_TruncatesTrailingSpace() {
            var someColumnNumberThatWontInterfereWithTheTextValue = 100;
            var aStringWithTrailingSpaces = "Hi Mom!     ";

            var expectedResult = "Hi Mom!";
            var actualResult = Wrapper.Wrap(aStringWithTrailingSpaces, someColumnNumberThatWontInterfereWithTheTextValue);

            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Take the following sentance where dashes respresent spaces:
        ///    This-is-an-amazing-------test.
        /// This would be interpreted as follows:
        ///    This-is-an-amazing\ntest.
        /// </summary>
        [Test]
        public void Wrap_MultipleSpaceCharacters_RemainingSpaceCharactersAreTruncated() {
            var columnNumberThatFallsOnASpace = 12;
            var aStringWithConsecutiveInternalSpaces = "Lorem ipsum     dolor sit amet";

            var expectedResult = "Lorem ipsum\ndolor sit amet";
            var actualResult = Wrapper.Wrap(aStringWithConsecutiveInternalSpaces, columnNumberThatFallsOnASpace);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Wrap_SuppliedTextRequiresMultipleBreaks_BreaksMultileLines() {
            var columnNumber = 25;
            var aStringThatRequiresMultipleBreaks =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean tempus sit amet sem non sodales. Morbi id erat non dui condimentum sodales et vel ex.";

            var expectedResult =
                "Lorem ipsum dolor sit\namet, consectetur\nadipiscing elit. Aenean\ntempus sit amet sem non\nsodales. Morbi id erat\nnon dui condimentum\nsodales et vel ex.";

            var actualResult = Wrapper.Wrap(aStringThatRequiresMultipleBreaks, columnNumber);

            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}
