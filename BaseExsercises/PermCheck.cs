using System;
using Xunit;

namespace BaseExsercises
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != i + 1)
                    return 0;
            }

            return 1;
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new int[] { 1, 2, 2, 5 }, 0)]
        public void ExampleInputTest(int[] input, int expected)
        {
            var result = solution(input);
            Assert.Equal(expected, result);
        }
    }
}
