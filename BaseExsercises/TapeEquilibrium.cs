using System;
using Xunit;

namespace BaseExsercises
{
    public class TapeEquilibrium
    {
        public int solution(int[] A) 
        {
            var right = 0;
            foreach (var item in A)
            {
                right += item;
            }

            var left = 0;
            var result = int.MaxValue;
            for (var i = 0; i < A.Length - 1; i++)
            {
                right -= A[i];
                left += A[i];

                var abs = Math.Abs(right - left);
                result = Math.Min(abs, result);
            }

            return result;
        }

        [Theory]
        [InlineData(new int[] { 3, 1 }, 2)]
        [InlineData(new int[] { 3, 1, 2, 4, 3 }, 1)]
        [InlineData(new int[] { -3, -1, -2, -4, -3 }, 1)]
        [InlineData(new int[] { -3, -1, -2, 4, 3 }, 5)]
        public void ExampleInputTest(int[] input, int minDiff)
        {
            var result = solution(input);
            Assert.Equal(minDiff, result);
        }
    }
}
