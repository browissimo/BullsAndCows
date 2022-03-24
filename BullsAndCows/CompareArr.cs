using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    internal class CompareArr
    {
        public static int[] FindCowAndBull(int[] input, int[] generated)
        {
            int cow = 0;
            int bull = 0;
            var inputList = input.ToList();
            var generatedList = generated.ToList();

            //Разрбраться с Capacity. При удалении элементов из списка в первом массиве, во втором массиве 4 итерации остается 

            for (int i = 0; i < inputList.Capacity; i++)
            {
                if (input[i] == generated[i])
                {
                    bull += 1;

                    inputList.Remove(i+1);
                    generatedList.Remove(i+1);

                }
            }

            for (int i = 0; i < inputList.Capacity; i++)
            {
                if (generatedList.Contains(inputList[i]))
                {
                    cow += 1;
                }
            }

            return new int[] {cow, bull};
        }
    }
}