using Xunit;

namespace BaseExsercises
{
    public class CyclicRotation
    {
        public int[] solution(int[] A, int K) 
        {
            if (K == 0 || A.Length == 0)
                return A;

            var result = new int[A.Length];
            for (var i = 0; i < A.Length; i++)
            {
                var index = i + K >= A.Length
                    ? (i + K) % A.Length
                    : i + K;

                result[index] = A[i];
            }

            return result;
        }
        
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[] { 0, 0, 0 }, 1, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        public void ExampleInputTest(int[] input, int shift, int[] expected)
        {
            var result = solution(input, shift);
            Assert.Equal(expected, result);
        }
    }
}
