using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    internal class ResultsCounter
    {
        public static string Count(int[] cowsAndBulls, int[] generatedArr)
        {
            string win = "Поздравляем, вы угадали!";

            if (cowsAndBulls[1] == 4)
            {
                Console.WriteLine(win);
                return string.Empty;
            }
            else
            {
                Console.WriteLine($"Колличество коров: {cowsAndBulls[0]}, колличество быков: {cowsAndBulls[1]}");
                ProgramBody.Body(generatedArr);
            }


            return "";
        }
    }
}
