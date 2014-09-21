using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    /// <remarks>
    /// I've renamed this class from IsHappyPrime to HappyPrimes to be a bit more idiomatic.
    /// </remarks>>
    public class HappyPrimes
    {
        public delegate bool IsPrimeDelegate(int value);

        /// <summary>
        /// A delegate that takes an int and returns a boolean stating whether or not 
        /// the supplied integer is prime.
        /// </summary>
        public IsPrimeDelegate IsPrimeFunction { get; private set; }

        /// <summary>
        /// Implements the HappyPrimes class with the default prime checking function.
        /// </summary>
        public HappyPrimes() {
            IsPrimeFunction = IsPrime;
        }

        /// <summary>
        /// Implemnts the HappyPrimes class with the supplied prime checking delegate.
        /// </summary>
        /// <param name="isPrimeDelegate">
        /// Expects a function that takes an int and returns a boolean.
        /// </param>
        /// <remarks>
        /// This overloaded method is supplied to enable testing of the IsHappyPrime function independant
        /// of the prime tester. (essentially allowing for the testing of happy numbers, not just primes).
        /// The inversion of control here also reduces refactoring overhead if better prime algorthms are implemented.
        /// </remarks>
        public HappyPrimes(IsPrimeDelegate isPrimeDelegate)
        {
            IsPrimeFunction = isPrimeDelegate;
        }

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
        public bool IsPrime(int input) {
            throw new NotImplementedException();
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
            //TODO: Use isprimefunction property rather than direct call to the internal IsPrime function.
		    throw new NotImplementedException();
	    }
    }
}
