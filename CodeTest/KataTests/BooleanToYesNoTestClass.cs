using System;
namespace CodeTest.KataTests
{
	public class BooleanToYesNoTestClass
	{
		public BooleanToYesNoTestClass()
		{
		}

		//Arrange
		public static IEnumerable<object[]> TestData => new List<Object[]>
		{
			new object[] {true, "Yes"},
            new object[] {false, "No"},
            new object[] {true, "Yes"}
        };

		[Theory]
		[MemberData(nameof(TestData))]
		public void ConvertBooleanToYesNoTest(bool Input, string expectedValue)
		{
			//Act
			var Response = CodeWars.Kata.BooleanToYesOrNo.ConvertBooleanToYesNo(Input);

			//Assert
			Assert.Equal(expectedValue, Response);
		}
    }
}