using BullsAndCows;

namespace BullsAndCows
{
    static class Program
    {
        public static void Main()
        {
            int[] arrToComapre = NumberGenerator.Generate();
            int tryCount = 10;

            Console.WriteLine("Загадано 4-значное число, состоящее из неповторяющихся цифр");
            Console.WriteLine("Ваша задача — угадать его за ограниченное число ходов. \n " +
                "В качестве подсказок выступают «коровы» (цифра угадана, но её позиция — нет) \n " +
                "и «быки» (когда совпадает и цифра, и её позиция).");

            ProgramBody.Body(arrToComapre, tryCount);
        }
    }

}



