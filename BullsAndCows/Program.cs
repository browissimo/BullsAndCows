using BullsAndCows;

namespace BullsAndCows
{
    static class Program
    {
        static void Main()
        {
            bool valid = false;
            int cow = 0;
            int bull = 0;
            string inputString = string.Empty;

            Console.WriteLine("Введите 4-значное число, состоящее из неповторяющихся цифр.");

            while (!valid)
            {
                inputString = Console.ReadLine();
                valid = InputParce.TryParce(inputString);
            }

            int[] inputArr = new int[4];

            for (int i = inputArr.Length - 1; i >= 0; i--)
            {
                inputArr[i] = Convert.ToInt32(char.GetNumericValue(inputString[i]));
            }

            int[] arrToComapre = NumberGenerator.Generate();


        }
    }

}



