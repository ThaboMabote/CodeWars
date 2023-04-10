using System;
namespace CodeTest.KataTests
{
	public class FakeBinaryTestClass
	{
		public FakeBinaryTestClass()
		{
		}

		//Arrenge
		public static IEnumerable<object[]> TestCases => new List<object[]>
		{
			new object[] {"45385593107843568", "01011110001100111"},
            new object[] {"509321967506747", "101000111101101"},
            new object[] {"366058562030849490134388085", "011011110000101010000011011"}
        };

		[Theory]
		[MemberData(nameof(TestCases))]
		public void FakeBinaryTest(string InputString, string ExpectedValue)
		{
			//Act
			var Response = CodeWars.Kata.FakeBinary.FakeBine(InputString);
			//Assert
			Assert.Equal(ExpectedValue, Response);
        }

		[Theory]
		[MemberData(nameof(TestCases))]
        public void FakeBinaryOptimisedTest(string InputString, string ExpectedValue)
        {
            //Act
            var OptimisedValue = CodeWars.Kata.FakeBinary.FakeBineOptimsed(InputString);
            //Assert
            Assert.Equal(ExpectedValue, OptimisedValue);
        }


        [Theory]
        [MemberData(nameof(TestCases))]
        public void FakeBinaryMostOptimisedTest(string InputString, string ExpectedValue)
        {
            //Act
            var OptimisedValue = CodeWars.Kata.FakeBinary.FakeBineMostOptimsed(InputString);
            //Assert
            Assert.Equal(ExpectedValue, OptimisedValue);
        }
    }
}

