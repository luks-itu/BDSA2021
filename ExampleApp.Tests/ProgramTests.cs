using System;
using Xunit;



namespace ExampleApp.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(1600)]
        [InlineData(2000)]
        public void yearIsDivisibleByFour(int providedYear)
        {
            
            bool yearIsDivisibleByFour = providedYear%4 == 0;
            bool isLeapYear = Program.IsLeapYear(providedYear);

            if(isLeapYear)
            { 
                Assert.True(yearIsDivisibleByFour);
            }
        }

        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(1600)]
        [InlineData(2000)]
        public void centurialYearIsALeapYear(int providedYear)
        {
            bool yearIsDivisiblebyOneHundred = providedYear%100 == 0;
            bool yearIsDivisbleByFourHundred = providedYear%400 == 0;
            bool isLeapYear = Program.IsLeapYear(providedYear);

            if(isLeapYear & yearIsDivisiblebyOneHundred)
            {
                Assert.True(yearIsDivisbleByFourHundred);
            }
        }
    }
}
