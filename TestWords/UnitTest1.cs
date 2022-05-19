using ProjectEuler17;
using Xunit;

namespace TestWords
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4, 4321)]
        [InlineData(0, 0321)]
        [InlineData(1, 1010)]
        [InlineData(1, 1111)]
        [InlineData(1, 1001)]
        [InlineData(0, 0001)]
        [InlineData(9, 9999)]
        [InlineData(0, 0999)]
        [InlineData(1, 1000)]
        public void TestFirstPosition(int output, int input)
        {
            int[] array = new int[] { 0, 0, 0, 0, };
            array = ArrayClass.NumberToDigits(input);
            Assert.Equal(output, array[0]);
        }

        [Theory]
        [InlineData(3, 4321)]
        [InlineData(3, 0321)]
        [InlineData(0, 1010)]
        [InlineData(1, 1111)]
        [InlineData(0, 1001)]
        [InlineData(0, 0001)]
        [InlineData(9, 9999)]
        [InlineData(9, 0999)]
        [InlineData(0, 1000)]
        public void TestSecondPosition(int output, int input)
        {
            int[] array = new int[] { 0, 0, 0, 0, };
            array = ArrayClass.NumberToDigits(input);
            Assert.Equal(output, array[1]);
        }

        [Theory]
        [InlineData(2, 4321)]
        [InlineData(2, 0321)]
        [InlineData(1, 1010)]
        [InlineData(1, 1111)]
        [InlineData(0, 1001)]
        [InlineData(0, 0001)]
        [InlineData(9, 9999)]
        [InlineData(9, 0999)]
        [InlineData(0, 1000)]
        public void TestThirdPosition(int output, int input)
        {
            int[] array = new int[] { 0, 0, 0, 0, };
            array = ArrayClass.NumberToDigits(input);
            Assert.Equal(output, array[2]);
        }

        [Theory]
        [InlineData(1, 4321)]
        [InlineData(1, 0321)]
        [InlineData(0, 1010)]
        [InlineData(1, 1111)]
        [InlineData(1, 1001)]
        [InlineData(1, 0001)]
        [InlineData(9, 9999)]
        [InlineData(9, 0999)]
        [InlineData(0, 1000)]
        public void TestFourthPosition(int output, int input)
        {
            int[] array = new int[] { 0, 0, 0, 0, };
            array = ArrayClass.NumberToDigits(input);
            Assert.Equal(output, array[3]);
        }
    }
}