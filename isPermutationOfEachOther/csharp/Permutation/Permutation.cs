using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class Permutation
    {
        /// <summary>
        /// Given two input strings, this function determines if the strings are permutations of each other.
        /// </summary>
        /// <param name="input1">The first string to consider.</param>
        /// <param name="input2">The second string to consider.</param>
        /// <returns>
        /// <para>Returns true if the strings are permutations of each other.</para>
        /// <para>Returns false if the strigs are not permutations of each other.</para>
        /// </returns>
        /// <remarks>
        /// <para>In the original spec, this method was proposed with private scope. 
        /// I have made the method public to ease testing, but this could be changed.</para>
        /// <para>This implementation only considers full, bi-directional (commutative) permutations, 
        /// therefor if the length of each input string do not match, false is returned.</para>
        /// <para>Nulls are regarded as non-permutable, and result in a nullargumentexception.</para>
        /// </remarks>
        public bool IsPermutationOfEachOther(string input1, string input2){
	        throw new NotImplementedException();
	    }
	
    }
}
