using System;
using CodeWars.Kata;
namespace CodeTest.KataTests
{
	public class StringToInt
	{
		public StringToInt()
		{
		}

		//Arrange
		public static IEnumerable<object[]> RequestData => new List<object[]>
		{
			new object[] {"1", 1 },
			new object[] {"13", 13 },
			new object[] {"1000", 1000 },
			new object[] {"58", 58 },
			new object[] {"@", 0 },
			new object[] {"-8", -8 }
		};

		[Theory]
		[MemberData(nameof(RequestData))]
		public void ConvertStringToIntTest(string NumberInput, int ExpectedNumber)
		{
			//Act
			var ResponseValue = CodeWars.Kata.StringToInt.ConvertStringToInt(NumberInput);

			//Assert
			Assert.Equal(ExpectedNumber, ResponseValue);
		}
    }
}

