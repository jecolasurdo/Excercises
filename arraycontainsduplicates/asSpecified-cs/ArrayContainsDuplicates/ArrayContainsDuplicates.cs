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
        /// <remarks>
        /// Algorithmic Complexity: O(n)
        /// This is based on Distinct's use of hashing and the integer type's default equality comparer. O(n) is likely a worst case.
        /// Each Count method is O(1), which is negligible to the overall result.
        /// </remarks>
        /// <returns>
        /// Returns true if the integer array contains duplicates.
        /// Returns false if the integer array does not contain duplicates.
        /// </returns>
        public bool ContainsDuplicates(int[] input)
        {
            if (input == null)
            {
               return true;
            }

            if (input.Count() == 0)
            {
                return true;
            }

            return input.Distinct().Count() != input.Count();

        }
    }
}
