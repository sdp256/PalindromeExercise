using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string x)
        {

            var xReversed = x.Reverse();
            return x.SequenceEqual(xReversed);
            //string xReversed =  x.Reverse().ToString();
            //if (x == xReversed)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            
        }

    }
}
