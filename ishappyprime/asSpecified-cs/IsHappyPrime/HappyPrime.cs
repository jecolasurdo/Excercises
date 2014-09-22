using System;

namespace Katas
{
    /// <remarks>
    /// I've renamed this class from IsHappyPrime to HappyPrimes to be a bit more idiomatic.
    /// </remarks>>
    public class HappyPrimes : IHappyPrimes
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
            if (IsPrimeFunction(input) == false)
            {
                return false;
            }
            
            var product = 0.0;
            const double epsilon = 0.000001;
            while (true)
            {
                char[] digitArray = null;
                if (Math.Abs(product) < epsilon)
                {
                    digitArray = string.Format("{0}", input).ToCharArray();
                }
                else
                {
                    digitArray = string.Format("{0}", product).ToCharArray();
                    product = 0;
                }
                
                foreach (var digit in digitArray)
                {
                    var i = double.Parse(digit.ToString());
                    product = product + (Math.Pow(i,2));
                }
                if (Math.Abs(product - 1.0) < epsilon)
                {
                    return true;
                }
                if (Math.Abs(product - 4.0) < epsilon)
                {
                    return false;
                }                
            }
        }
    }
}
