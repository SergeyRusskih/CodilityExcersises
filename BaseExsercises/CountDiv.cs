using Xunit;

namespace BaseExsercises
{
    public class CountDiv
    {
        public int solution(int A, int B, int K)
        {
            return A % K > 0
                ? (B / K - A / K)
                : (B / K - A / K) + 1;
        }

        [Theory]
        [InlineData(6, 11, 2, 3)]
        [InlineData(2, 6, 2, 3)]
        [InlineData(6, 7, 2, 1)]
        [InlineData(11, 345, 17, 20)]
        public void ExampleInputTest(int start, int stop, int divider, int count)
        {
            var result = solution(start, stop, divider);
            Assert.Equal(count, result);
        }
    }
}
