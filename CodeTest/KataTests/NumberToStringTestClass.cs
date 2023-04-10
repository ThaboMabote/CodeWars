using System;
using CodeWars.Kata;
namespace CodeTest.KataTests
{
	public class NumberToStringTestClass
	{
		public NumberToStringTestClass()
		{
		}

		//Arrange
		public static IEnumerable<object[]> TestData => new List<object[]>
		{
			new object[] {1, "1"},
            new object[] {-45, "-45"},
            new object[] {171, "171"}
        };

		[Theory]
		[MemberData(nameof(TestData))]
		public void ConvertNumberToStringTest(int Input, string expectedValue)
		{
			//Act
			var Response = NumberToString.ConvertNumberToString(Input);

			//Assert
			Assert.Equal(expectedValue, Response);
        }
    }
}