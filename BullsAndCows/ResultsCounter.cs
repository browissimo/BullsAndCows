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
            string win = $"Поздравляем, вы угадали! \n Вам потребовалось всего {cowsAndBulls[2]} попыток";

            if (cowsAndBulls[2] == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("К сожалению, вы проиграли");
                Console.ResetColor();
            }
            else if  (cowsAndBulls[1] == 4)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(win);
                Console.ResetColor();
                return string.Empty;
            }
            else
            {
                Console.WriteLine($"Колличество коров: {cowsAndBulls[0]}, колличество быков: {cowsAndBulls[1]}");
                Console.WriteLine($"У вас осталось {cowsAndBulls[2]} попоыток");
                Console.WriteLine("");
                ProgramBody.Body(generatedArr, cowsAndBulls[2]);
            }

            return "";
        }
    }
}
