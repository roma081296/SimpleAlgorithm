using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Algorithm.Tests
{
    public class AlgorithmTests
    {

        [Fact]
        public void Should_Return_When_Empty()
        {
            int[] input = new int[1];

            var value = Findtotal.find_total(input);

            Assert.Equal(0, value);

        }
        [Fact]
        public void Should_Return_When_Only_Even_Num_No_8s()
        {
            int[] input = { 4, 2, 10, 12,16 };

            var value = Findtotal.find_total(input);

            Assert.Equal(5, value);

        }
        [Fact]
        public void Should_Return_When_Only_Even_Num_With_8s()
        {
            int[] input = { 4, 2, 8, 12, 16 };

            var value = Findtotal.find_total(input);

            Assert.Equal(9, value);
        }
        [Fact]
        public void Should_Return_When_Only_Odd_Num()
        {
            int[] input = {  15, 25, 35 };

            var value = Findtotal.find_total(input);

            Assert.Equal(9, value);
        }
        [Fact]
        public void Should_Return_When_Only_8s_Num()
        {
            int[] input = { 8, 8, 8 };

            var value = Findtotal.find_total(input);

            Assert.Equal(15, value);
        }
        [Fact]
        public void Should_Return_When_Odd_Even_Num_No_8s()
        {
            int[] input = { 1,2, 3, 4,5 };

            var value = Findtotal.find_total(input);

            Assert.Equal(11, value);

        }
        [Fact]
        public void Should_Return_When_Odd_Even_Num_With_8s()
        {
            int[] input = { 1, 2, 3,8, 4, 5 };

            var value = Findtotal.find_total(input);

            Assert.Equal(16, value);

        }

        [Fact]
        public void Should_Return_When_Odd_Even_Num_Negative_With_8s()
        {
            int[] input = { -1, 2, 3, 8, -4, 5 };

            var value = Findtotal.find_total(input);

            Assert.Equal(16, value);

        }
    }
}