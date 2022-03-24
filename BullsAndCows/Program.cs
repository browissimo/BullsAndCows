using BullsAndCows;

namespace BullsAndCows
{
    static class Program
    {
        public static void Main()
        {
            int[] arrToComapre = NumberGenerator.Generate();

            ProgramBody.Body(arrToComapre);
        }
    }

}



