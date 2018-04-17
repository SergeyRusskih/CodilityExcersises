namespace BaseExsercises
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A) 
        {
            var result = 0;
            foreach (var item in A)
            {
                result ^= item;
            }

            return result;
        }
    }
}
