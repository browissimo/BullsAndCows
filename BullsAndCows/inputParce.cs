using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    internal class InputParce
    {
        public static bool TryParce(string input)
        {
            const string message = "Введите 4-значное число, состоящее из неповторяющихся цифр.";

            if (string.IsNullOrEmpty(input))
            {
                Console.Clear();
                Console.WriteLine(message);
                return false;
            }

            if (input.Length != 4)
            {
                Console.Clear();
                Console.WriteLine(message);
                return false;
            }

            var inputToArr = input.ToCharArray();

            foreach (var c in inputToArr)
            {
                if (!char.IsDigit(c))
                {
                    Console.Clear();
                    Console.WriteLine(message);
                    return false;
                }
            }

            var disc = input.Distinct();

            if (disc.ToArray().Length != 4)
            {
                Console.Clear();
                Console.WriteLine(message);
                return false; 
            }

            return true;
        }
    }
}
