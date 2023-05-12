using System;
namespace CodeTest.KataTests
{
	public class dnaToRnaTestClass
	{
		public dnaToRnaTestClass()
		{
		}

		//Arrange
		public static IEnumerable<object[]> testData = new List<object[]>
		{
			new object[] {"TTTT","UUUU"},
            new object[] { "GCAT", "GCAU"},
            new object[] {"GTAGTUAT","GUAGUUAU"},
        };

		[Theory]
		[MemberData(nameof(testData))]
		public void dnaToRnaYest(string Input, string expectedValue)
		{
			//Act
			string Response = CodeWars.Kata.dnaToRnaClass.dnaToRna(Input);

			//Assert
			Assert.Equal(expectedValue, Response);
		}

    }
}

