using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfMultiple
{
    public class Sum
    {
        // Evaluates the sum of all natural numbers that are a 
        // multiple of _divisor below a limit provided as _input.
        // Algorithm will be like that:
        // lets say input is as "x", output is as "y",
        // "x/3" gives how many "3 multiple" numbers exist below x. Lets say it is "n". 
        // y = (3+6+9+...) -> n numbers
        // lets take in "3" parahthesis -> y = 3 * (1+2+3+..+n) 
        // the formula for sum of "n" numbers -> y = 3 * (n*(n+1)/2)
        public static int evalSum(int _input, int _divisor)
        {
            int sum, count;
            count = (_input / _divisor);
            sum = (count * (count + 1) / 2) * _divisor;
            return sum;
        }
    }
}
