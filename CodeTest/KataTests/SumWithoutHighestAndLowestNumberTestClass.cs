using System;
namespace CodeTest.KataTests
{
	public class SumWithoutHighestAndLowestNumberTestClass
	{
		public SumWithoutHighestAndLowestNumberTestClass()
		{
		}

		//Arrange
		public static IEnumerable<object[]> testData => new List<object[]>
		{
			new object[] { new[] { 6, 2, 1, 8, 10 }, 16},
			new object[] { new[] { 1, 1, 11, 2, 3 }, 6 },
            new object[] { new[] { 1, 1, 11, 11, 11, 1, 2, 3 }, 29 }
        };

		[Theory]
		[MemberData(nameof(testData))]
		public void SumWithoutHighestAndLowestNumber(int[] Inputs, int ExpectedValue)
		{
			//Act
			var Response = CodeWars.Kata.SumWithoutHighestAndLowestNumberClass.SumWithoutHighestAndLowestNumber(Inputs);

			//Assert
			Assert.Equal(ExpectedValue, Response);
		}
    }
}

