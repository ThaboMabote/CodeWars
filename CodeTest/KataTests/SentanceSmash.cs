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

		//Arrenge
		public static IEnumerable<object[]> ReverseStringTestData => new List<object[]>
		{
			new object[]{"Hello", "olleH"},
			new object[]{ "world", "dlrow" }
		};

		[Theory]
		[MemberData(nameof(ReverseStringTestData))]
		public void ReverseStringTest(string word, string expectedValue)
		{
			//Act
			string ReturnedValue = CodeWars.Kata.SentenceSmash.SentenceSmash.ReverseString(word);

			//Assert
			Assert.Equal(expectedValue, ReturnedValue);
		}


		[Theory]
		[MemberData(nameof(ReverseStringTestData))]
		public void ReverseStringTestBestApprach(string word, string expectedValue)
		{
			//Act
			string ReturnedValue = CodeWars.Kata.SentenceSmash.SentenceSmash.ReverseStringBestApproach(word);

			//Assert
			Assert.Equal(expectedValue, ReturnedValue);
		}

        //Arrenge
        public static IEnumerable<object[]> IsIsogramTestData => new List<object[]>
		{
			new object[] {"iuwefhiueffe", false},
			new object[] {"qwerty", true},
			new object[] {"qazwsxedc", true},
			new object[] {"duhduh", false},
			new object[] {"konuhbtfx", true}
		};

        [Theory]
		[MemberData(nameof(IsIsogramTestData))]
		public void IsIsogramTest(string Word, bool expectedValue)
		{
			//Act
			var ReturnValue = CodeWars.Kata.SentenceSmash.SentenceSmash.IsIsogram(Word);

			//Assert
			Assert.Equal(expectedValue, ReturnValue);
		}

        [Theory]
        [MemberData(nameof(IsIsogramTestData))]
        public void IsIsogramMyBestSolutionTest(string Word, bool expectedValue)
        {
            //Act
            var ReturnValue = CodeWars.Kata.SentenceSmash.SentenceSmash.IsIsogramMySolutionBestApproach(Word);

            //Assert
            Assert.Equal(expectedValue, ReturnValue);
        }

        [Theory]
        [MemberData(nameof(IsIsogramTestData))]
        public void IsIsogramBestApproach(string Word, bool expectedValue)
        {
            //Act
            var ReturnValue = CodeWars.Kata.SentenceSmash.SentenceSmash.IsIsogramBestApproach(Word);

            //Assert
            Assert.Equal(expectedValue, ReturnValue);
        }
    }
}