using System;
using Xunit;

namespace Example.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(-2)]
        [InlineData(-1)]
        [InlineData(0)]
        public void FizzBuzz_WhenInvalidInput_OutputError(int input)
        {
            //Assert
            Assert.Throws<ArgumentException>(() => FizzBuzz.GetFizzBuzzOutput(input));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(11)]
        [InlineData(14)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(19)]
        public void FizzBuzz_WhenRegularNumber_OutputInput(int input)
        {
            //Act
            string output = FizzBuzz.GetFizzBuzzOutput(input);

            //Assert
            Assert.Equal(output, output);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(18)]
        public void FizzBuzz_WhenMultipleOf3_OutputFizz(int input)
        {
            //Act
            string output = FizzBuzz.GetFizzBuzzOutput(input);

            //Assert
            Assert.Equal("fizz", output);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void FizzBuzz_WhenMultipleOf5_OutputBuzz(int input)
        {
            //Act
            string output = FizzBuzz.GetFizzBuzzOutput(input);

            //Assert
            Assert.Equal("buzz", output);
        }
        [Theory]
        [InlineData(15)]
        public void FizzBuzz_WhenMultipleOf15_OutputFizzBuzz(int input)
        {
            //Act
            string output = FizzBuzz.GetFizzBuzzOutput(input);

            //Assert
            Assert.Equal("fizzbuzz", output);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(13)]
        public void FizzBuzz_WhenContains3_OutputLucky(int input)
        {
            //Act
            string output = FizzBuzz.GetFizzBuzzOutput(input);

            //Assert
            Assert.Equal("lucky", output);
        }
    }
}
