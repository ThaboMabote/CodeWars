using System;
namespace CodeWars.Kata
{
	public static class NumberToString
	{
		public static string ConvertNumberToString(int Input) => Input.ToString();

		public static string stringConvertNumberToStringBad(int Number)
		{
            var trash = new List<int>
            {
                1, 2, 3
            };

            int num = 0;
return Convert.ToString(
      Convert.ToInt32(
      Convert.ToString(
        num.ToString()
      .ToString()
      .ToString()
      .ToString()
      .ToString()
      .ToString()
      .ToString()
      .ToString()
      .ToString())));
        }
	}
}