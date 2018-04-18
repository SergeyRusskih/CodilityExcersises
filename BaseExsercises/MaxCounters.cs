using System;
using Xunit;

namespace BaseExsercises
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            var counters = new int[N];

            var max = 0;
            var sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                var current = A[i];
                if (counters.Length < current)
                {
                    sum += max;
                    max = 0;
                }
                else
                {
                    var index = current - 1;
                    if (counters[index] < sum)
                        counters[index] = sum;

                    counters[index]++;
                    max = Math.Max(max, counters[index] - sum);
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                if (counters[i] < sum)
                    counters[i] = sum;
            }

            return counters;
        }

        [Theory]
        [InlineData(new[] { 3, 4, 4, 6, 1, 4, 4 }, 5, new[] { 3, 2, 2, 4, 2 })]
        [InlineData(new[] { 1, 4, 1 }, 1, new[] { 2 })]
        [InlineData(new[] { 3, 10, 4, 6, 1, 7, 4 }, 5, new[] { 3, 3, 3, 4, 3 })]
        public void ExampleInputTest(int[] input, int counter, int[] expected)
        {
            var result = solution(counter, input);
            Assert.Equal(expected, result);
        }
    }
}