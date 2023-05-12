using System;
namespace CodeWars.Kata
{
	public static class SumWithoutHighestAndLowestNumberClass
	{
		public static int SumWithoutHighestAndLowestNumber(int[] numbers)
		{
            // Input validation
            if (numbers == null || numbers.Length <= 1)
            {
                return 0;
            }

            // Find the highest and lowest elements
            int highest = numbers.Max();
            int lowest = numbers.Min();

            // Calculate the sum excluding the highest and lowest elements
            int sum = numbers.Sum() - highest - lowest;

            return sum;
        }
    }
}