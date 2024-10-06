using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100DaysEasyLeetCode.LeetCode
{
    public class Day2_Solution
    {
        public bool IsPalindrome(int x)
        {
            int rev, sum = 0;
            int temp = x;
            while (x > 0)
            {
                rev = x % 10;
                sum = (sum * 10) + rev;
                x = x / 10;
            }
            return temp == sum;
        }
    }
}
