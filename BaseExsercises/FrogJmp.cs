using Xunit;

namespace BaseExsercises
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D) 
        {
            var diff = (Y - X) % D;
            var result = diff > 0
                ? ((Y - X) / D) + 1
                : (Y - X) / D;
            
            return result;
        }

        [Theory]
        [InlineData(10, 85, 30, 3)]
        public void ExampleInputTest(int x, int y, int d, int expected)
        {
            var result = solution(x, y, d);
            Assert.Equal(expected, result);
        }
    }
}
