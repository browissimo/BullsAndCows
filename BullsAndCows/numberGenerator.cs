using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    internal class NumberGenerator
    {
        public static int[] Generate()
        {
            var random = new Random();
            int[] array = new int[4];
            for (int i = 0; i < array.Length; ++i)
            {
                bool qnic;
                do
                {
                    array[i] = random.Next(0, 9);
                    qnic = true;
                    for (int j = 0; j < i; ++j)
                        if (array[i] == array[j])
                        {
                            qnic = false;
                            break;
                        }
                } while (!qnic);
            }

            return array;
        }
    }
}
