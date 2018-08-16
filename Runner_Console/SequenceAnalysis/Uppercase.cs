using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceAnalysis
{
    public class Uppercase
    {
        // Finds the uppercase words in a string
        public static string findUppers(string _str)
        {
            string upperStr = "";
            for (int i = 0; i < _str.Length; i++)
            {
                if (char.IsUpper(_str[i]))
                {
                    upperStr += _str[i];
                }
            }
            return upperStr;
        }

        // Order all characters in these words alphabetically
        public static string Alphabetize(string _str)
        {
            char[] aStr = _str.ToCharArray();
            Array.Sort(aStr);
            return new string(aStr);
        }


    }
}
