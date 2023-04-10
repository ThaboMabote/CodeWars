using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars.Kata
{
	public static class FakeBinary
	{
		public static string FakeBine(string input)
		{
			string StringToReturn = "";
			for(var i = 0; i < input.Length; i++)
			{
				int CurrentNumber = 0;
				var Success = int.TryParse(input.Substring(i, 1), out CurrentNumber);
				if(Success == true)
				{
					if(CurrentNumber >= 5)
					{
						StringToReturn += 1;
                    }
					else if (CurrentNumber < 5)
                    {
						StringToReturn += 0;
                    }
					else
					{
						StringToReturn += CurrentNumber;
                    }
				}
			}
			return StringToReturn;
        }

		public static string FakeBineOptimsed(string input)
		{
			StringBuilder stringToReturn = new StringBuilder(input.Length);

			for(var i = 0; i < input.Length; i++)
			{
				//WHY WE NEED TO - '0' WHEN GETTING THE VALUE OF A SINGLE VALUE FROM A STRING USING AN INDEX
				//input[i] - '0' to convert the character at position i in the input string to its corresponding integer value. Here's why it works:
				//Each character has a numeric value(the Unicode code point) associated with it.For example, the character '0' has the Unicode code point 48, '1' has 49, '2' has 50, and so on, up to '9' with 57.
				//When you write input[i] -'0', you are actually performing subtraction between the Unicode code points of the characters at position i in the input string and the character '0'.Since the Unicode code points for the characters '0' through '9' are consecutive, subtracting the Unicode code point of '0'(which is 48) from the Unicode code point of any digit character will result in the corresponding integer value of that digit.
				//For example, if input[i] is '3', then the expression input[i] -'0' evaluates to 51 - 48 = 3, which is the integer value of the character '3'.
				int CurrentNumber = input[i] - '0';
				stringToReturn.Append(CurrentNumber < 5 ? "0" : "1");
            }
			return stringToReturn.ToString();
        }

        public static string FakeBineMostOptimsed(string input)
        {
			return string.Concat(input.Select(a => a < '5' ? "0" : "1"));
        }
    }
}
//Assert.AreEqual("01011110001100111", Kata.FakeBin("45385593107843568"));
//Assert.AreEqual("101000111101101", Kata.FakeBin("509321967506747"));
//Assert.AreEqual("011011110000101010000011011", Kata.FakeBin("366058562030849490134388085"));