using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class Wrapper
    {
        /// <summary>
        /// Takes a string of text and inserts linebreak characters according to the supplied column number.
        /// </summary>
        /// <param name="textToWrap">The text you want to have wrapped.</param>
        /// <param name="columnToWrapAt">The column number at which you want to wrap the text.</param>
        /// <returns>
        /// Returns the wrapped text.
        /// </returns>
        /// <remarks>
        /// 
        /// </remarks>
        public static string Wrap(string textToWrap, int columnToWrapAt) {
            if (columnToWrapAt < 0)
            {
                throw new ArgumentOutOfRangeException("columnToWrapAt","The wrap column value must be a positive integer.");
            }
            throw new NotImplementedException();
        }
    }
}
