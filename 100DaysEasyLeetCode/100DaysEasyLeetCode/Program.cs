using _100DaysEasyLeetCode.LeetCode;
namespace _100DaysEasyLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Day1_Solution day1 = new Day1_Solution();
            Day2_Solution day2 = new Day2_Solution();
            Console.WriteLine("Hello, World!");
            day1.TwoSum(new int[] { 2,7,11,15},9);
            day2.IsPalindrome(1543451);
            Console.ReadKey();
        }
    }
}
