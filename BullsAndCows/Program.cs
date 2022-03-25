using BullsAndCows;

namespace BullsAndCows
{
    static class Program
    {
        public static void Main()
        {
            int[] arrToComapre = NumberGenerator.Generate();
            int tryCount = 10;

            ProgramBody.Body(arrToComapre, tryCount);
        }
    }

}



