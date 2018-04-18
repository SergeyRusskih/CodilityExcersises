using Xunit;

namespace BaseExsercises
{
    public class FrogRiver
    {
        public int solution(int X, int[] A)
        {
            var buffer = new bool[X + 1];
            var count = X;

            for (int i = 0; i < A.Length; i++)
            {
                var current = A[i];
                if (current > X)
                    continue;

                if (buffer[current])
                    continue;

                buffer[current] = true;
                count--;

                if (count == 0)
                    return i;
            }

            return -1;
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 1, 4, 2, 3, 5, 4  }, 5, 6)]
        [InlineData(new int[] { 1, 2, 2, 5 }, 5, -1)]
        public void ExampleInputTest(int[] input, int position, int expected)
        {
            var result = solution(position, input);
            Assert.Equal(expected, result);
        }
    }
}