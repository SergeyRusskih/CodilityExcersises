using System;
using Xunit;

namespace BaseExsercises
{
    public class MissingInteger
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            var first = A[0];
            if (first > 1)
                return 1;

            for (int i = 1; i < A.Length; i++)
            {
                var prev = A[i - 1];
                var current = A[i];
                if (prev <= 0 && current <= 0)
                    continue;

                var diff = current - prev;
                if (diff > 1)
                {
                    for (int j = 1; j < diff; j++)
                    {
                        var candidate = prev + j;
                        if (candidate > 0)
                            return candidate;
                    }
                }
            }

            var last = A[A.Length - 1];
            if (last > 0)
                return last + 1;

            return 1;
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [InlineData(new int[] { 1, 2, 3 }, 4)]
        [InlineData(new int[] { -1, -3 }, 1)]
        public void ExampleInputTest(int[] input, int expected)
        {
            var result = solution(input);
            Assert.Equal(expected, result);
        }
    }
}