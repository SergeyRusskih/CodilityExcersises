using System;
using Xunit;

namespace Codility
{
    public class BinaryGap
    {
        public int solution(int N) 
        {
            var array = Convert.ToString(N, 2);

            var gap = 0;
            var currentGap = int.MinValue;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == '0' && currentGap != int.MinValue)
                {
                    currentGap++;
                }
                else
                {
                    gap = Math.Max(gap, currentGap);
                    currentGap = 0;
                }
            }

            return gap;
        }

        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(1041, 5)]
        public void ExampleInputTest(int input, int gap)
        {
            var result = solution(input);
            Assert.Equal(gap, result);
        }
    }
}
