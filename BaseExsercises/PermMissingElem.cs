using Xunit;

namespace BaseExsercises
{
    public class PermMissingElem
    {
        public int solution(int[] A) 
        {
            var sum = 0;
            foreach (var item in A)
            {
                sum += item;
            }

            var fullSum = 0;
            for (int i = 0; i <= A.Length; i++)
            {
                fullSum += i + 1;
            }

            return fullSum - sum;
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 4, 5 }, 3)]
        public void ExampleInputTest(int[] input, int expected)
        {
            var result = solution(input);
            Assert.Equal(expected, result);
        }
    }
}
