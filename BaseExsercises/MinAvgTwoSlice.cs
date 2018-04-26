using System;
using Xunit;

namespace BaseExsercises
{
    public class MinAvgTwoSlice
    {
        public int solution(int A[], int N);
        {
            
        }

        [Theory]
        [InlineData(new[] { 3, 4, 4, 6, 1, 4, 4 }, 1)]
        public void ExampleInputTest(int[] input, int expected)
        {
            var result = solution(counter, input);
            Assert.Equal(expected, result);
        }
    }
}