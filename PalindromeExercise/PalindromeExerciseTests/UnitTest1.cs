using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("tacocat", true)]
        [InlineData("falsetest", false)]
        public void IsAPalindrome(string x, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(x);
            //Assert
            Assert.Equal(actual, expected);

           
        }
    }
}
