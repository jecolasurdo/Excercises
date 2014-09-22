using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class ArrayContainsDuplicates
    {

        /// <summary>
        /// This method determines whether the input array contains any duplicate integers.
        /// </summary>
        /// <param name="input">
        /// An integer array to determine the duplicates of.
        /// </param>
        /// <returns>
        /// Returns true if the integer array contains duplicates.
        /// Returns false if the integer array does not contain duplicates.
        /// </returns>
        /// <remarks>
        /// Here I'm using a hashset object, which should be permissible as a similar object exists in java.util (as allowed in instructions)
        /// Algorithmic Complexity: O(1) - hashsets provide hashtable backing for very fast lookup, and allow for very efficient add performance.
        /// </remarks> 
        public bool ContainsDuplicates(int[] input) {
            if (input == null)
            {
                return false;
            }

            if (input.Count() == 0)
            {
                return false;
            }

            var hs = new HashSet<int>();
            foreach (var i in input)
            {
                if (hs.Contains(i))
                {
                    return true;
                }
                hs.Add(i);
            }
            return false;
        }
    }
}
