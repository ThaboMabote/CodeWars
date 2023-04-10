using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars.Kata
{
	public static class StringToInt
	{
		public static int ConvertStringToInt(string str)
		{
			int NumberToReturn = 0;
            var Success = int.TryParse(str, out NumberToReturn);

			return NumberToReturn;
        }
	}
}

