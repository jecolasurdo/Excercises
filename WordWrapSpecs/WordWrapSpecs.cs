using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Katas
{
    [TestFixture]
    public class WrapSpecs
    {
        [Test]
        public void Wrap_Normally_ReturnsWithoutExecption() {
            Assert.Inconclusive();
        }

        [Test]
        public void Wrap_StringIsEmpty_ReturnsEmptyString() {
            Assert.Inconclusive();
        }

        [Test]
        public void Wrap_ColumnNumberIsNegative_ThrowsArgumentException() {
            Assert.Inconclusive();
        }

        [Test]
        public void Wrap_ColumnNumberIsZero_ReturnsOriginalTextValue() {
            Assert.Inconclusive();
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
