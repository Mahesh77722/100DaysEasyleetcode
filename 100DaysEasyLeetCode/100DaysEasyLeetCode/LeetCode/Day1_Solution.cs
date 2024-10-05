using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100DaysEasyLeetCode.LeetCode
{
    public class Day1_Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int reminder = target - nums[i];
                if (result.ContainsKey(reminder))
                    return new int[] { result[reminder], i };
                else
                    result[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}
