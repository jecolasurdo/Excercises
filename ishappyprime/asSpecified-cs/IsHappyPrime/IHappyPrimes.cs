using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public interface IHappyPrimes
    {
        bool IsPrime(int input);
        bool IsHappyPrime(int input);
    }
}
