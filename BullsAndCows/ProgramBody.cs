using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    internal class ProgramBody
    {
        public static void Body(int[] arr, int tryCount)
        {
            bool valid = false;
            string inputString = string.Empty;
            int lenthForGame = 4;
            int[] arrToComapre = arr;

            Console.WriteLine("Введите 4-значное число, состоящее из неповторяющихся цифр.");

            while (!valid)
            {
                inputString = Console.ReadLine();
                valid = InputParce.TryParce(inputString);
            }

            int[] inputArr = new int[lenthForGame];

            for (int i = inputArr.Length - 1; i >= 0; i--)
            {
                inputArr[i] = Convert.ToInt32(char.GetNumericValue(inputString[i]));
            }

            ResultsCounter.Count(CompareArr.FindCowAndBull(inputArr, arrToComapre, tryCount), arr);

        }
    }
}
