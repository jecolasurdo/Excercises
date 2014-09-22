using System;
using System.Collections.Generic;

namespace Katas
{
    /// <remarks>
    /// I've renamed this class from IsHappyPrime to HappyPrimes to be a bit more idiomatic.
    /// </remarks>>
    public class HappyPrimes
    {

        /// <summary>
        /// Determines whether the input value is a prime number.
        /// </summary>
        /// <param name="input">
        /// An integer to determine the primality of.
        /// </param>
        /// <returns>
        /// Returns true if the supplied value is prime.
        /// Returns false if the supplied value is not prime.
        /// </returns>
        /// <remarks>
        /// Zero and one can be neither prime nor composite.
        ///   Since the excercize requires a boolean be returned, the function throws an exception in this case.
        ///   An alternative would be to have a tristate result - an enumm, or some other safe representation.
        /// A number of improvements can be made to this algorythm, but, since
        ///   it is already capabable of calculating the largest prime smaller than Int32.MaxValue 
        ///   in short order, this is probably good enough for now. (worst case scenario = 23k comparisons)
        /// </remarks>
        public bool IsPrime(int input) {
            if (input == 0 || input == 1)
            {
                throw new ArithmeticException("Zero and one are neither prime nor composite. This function cannot be used in this case.");
            }

            if (input < 0)
            {
                return false;
            }

            if (input == 2)
            {
                return true;
            }

            if (input%2 == 0)
            {
                return false;
            }

            var i = 3;
            while (i <= Math.Sqrt(Int32.MaxValue) && i < input)
            {
                if (input%i == 0)
                {
                    return false;
                }
                i = i + 2;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the input value is a "happy prime".
        /// e.g. a prime number that is also a happy number.
        /// </summary>
        /// <param name="input">
        /// An integer to determine the happyness of.
        /// </param>
        /// <returns>
        /// Returns true if the supplied integer is happy.
        /// Returns false if the supplied integer is not happy.
        /// </returns>
	    public bool IsHappyPrime(int input) {
            if (!IsPrime(input))
            {
                return false;
            }
            
            var product = 0;
            while (true)
            {
                int[] digitArray;
                if (product == 0)
                {
                    digitArray = ToDigitArray(input);
                }
                else
                {
                    digitArray = ToDigitArray(product);
                    product = 0;
                }
                
                foreach (var digit in digitArray)
                {
                    product = product + (int)(Math.Pow(digit,2));
                }
                if (product == 1)
                {
                    return true;
                }

                if (product == 4)
                {
                    return false;
                }                
            }
        }

        /// <summary>
        /// Converts an integer into an array of digits.
        /// </summary>
        /// <param name="n">
        /// The integer to convert to an array.
        /// </param>
        /// <returns>
        /// Returns an array of digits.
        /// </returns>
        /// <remarks>
        /// Throws an exception if a negative integer is passed in.
        /// This is an implementation of an idea found at:
        ///     http://stackoverflow.com/questions/4580261/integer-to-integer-array-c-sharp
        /// </remarks>
        public int[] ToDigitArray(int n) {
            if (n < 0)
            {
                throw new NotImplementedException("This method is currently only implemented for integers greater than or equal to zero.");
            }

            if (n == 0)
            {
                return new int[1] { 0 };
            }
            var digits = new List<int>();
            for (; n != 0; n /= 10)
            {
                digits.Add(n % 10);
            }
            var arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }

    }
}
