using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    internal class CompareArr
    {
        public static int[] FindCowAndBull(int[] input, int[] generated, int tryCount)
        {
            tryCount--;

            int cow = 0;
            int bull = 0;
            var inputList = input.ToList();
            var generatedList = generated.ToList();

            for (int i = inputList.Capacity - 1; i >= 0; i--)
            {
                if (input[i] == generated[i])
                {
                    bull += 1;

                    inputList.Remove(inputList.ElementAt(i));
                    generatedList.Remove(generatedList.ElementAt(i));

                }
            }

            for (int i = 0; i < inputList.Count; i++)
            {
                if (generatedList.Contains(inputList[i]))
                {
                    cow += 1;
                }
            }

            return new int[] {cow, bull, tryCount};
        }
    }
}