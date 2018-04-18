using Xunit;

namespace BaseExsercises
{
    public class PassingCars
    {
        public int solution(int[] A)
        {
            var left = 0;
            foreach (var item in A)
            {
                if (item == 0)
                    left++;
            }

            var pairs = 0;
            for (var i = A.Length - 1; i >= 0; i--)
            {
                if (pairs > 1000000000)
                    return -1;

                var current = A[i];
                if (current == 0)
                {
                    left--;
                    continue;
                }

                pairs += left;
            }

            return pairs;
        }

        [Theory]
        [InlineData(new[] { 0, 1, 0, 1, 1 }, 5)]
        public void ExampleInputTest(int[] input, int count)
        {
            var result = solution(input);
            Assert.Equal(count, result);
        }
    }
}
