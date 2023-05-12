using System;
using System.Linq;

namespace CodeWars.Kata.SentenceSmash
{
	public static class SentenceSmash
	{
		public static string Smash(string[] words)
		{
			return String.Join(" ", words);
		}

		public static string ReverseString(string Input)
		{
			string ReturnValue = "";
			foreach (char c in Input.Reverse())
			{
                ReturnValue += c;
            }
			return ReturnValue;
		}

        public static string ReverseStringBestApproach(string Input)
        {
            string ReturnValue = string.Concat(Input.Reverse());
            return ReturnValue;
        }

        public static bool IsIsogram(string str)
        {
            str = str.ToLower();
			var euniqueCharactors = str.Distinct();
			var ReturnValue = false;
			Dictionary<string, int> AlphabetIndex = new Dictionary<string, int>();

			foreach (var e in euniqueCharactors)
			{
				AlphabetIndex.Add(e.ToString(), 0);
            }

			foreach (char c in str) {
				if(AlphabetIndex.ContainsKey(c.ToString()))
				{
					AlphabetIndex[c.ToString()]++;
                }
			}

            foreach (var e in AlphabetIndex)
            {
				if(e.Value > 0)
				{
					return true;
				}
            }

            return ReturnValue;
        }

        public static bool IsIsogramMySolutionBestApproach(string str)
        {
            // Convert the string to lowercase to ignore letter case
            str = str.ToLower();

            // Create a dictionary to store the occurrence count of each character
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Iterate through each character in the string
            foreach (char c in str)
            {
                // If the character is already in the dictionary, increment its count
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                // Otherwise, add the character to the dictionary with a count of 1
                else
                {
                    charCount.Add(c, 1);
                }
            }

            // Check if any character count is greater than 1
            foreach (var count in charCount.Values)
            {
                if (count > 1)
                {
                    return false;
                }
            }

            // If no character count is greater than 1, the string is an isogram
            return true;
        }

        public static bool IsIsogramBestApproach(string Input)
		{
			return Input.All(c => Input.Count(cc => cc == c) == 1);
		}
    }
}

