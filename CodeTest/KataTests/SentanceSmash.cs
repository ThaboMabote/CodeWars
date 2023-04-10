using CodeWars.Kata;
namespace CodeTest.KataTests
{
	public class SentanceSmash
	{
		//Arrange
		public static IEnumerable<object[]> SamshTestData => new List<object[]>
		{
			new object[] {new[] {"Hello", "world" }, "Hello world"},
			new object[] { new[] { "I", "am", "a", "test" }, "I am a test" },
			new object[] { new[] { "No", "spaces", "at", "beginning", "or", "end" }, "No spaces at beginning or end" },
			new object[] { new string[0], "" }
		};

		[Theory]
		[MemberData(nameof(SamshTestData))]
		public void SmashTest(string[] words, string expectedValue)
		{
			//Act
			string ReturnedValue = CodeWars.Kata.SentenceSmash.SentenceSmash.Smash(words);
			
			//Assert
			Assert.Equal(expectedValue, ReturnedValue);
		}
	}
}