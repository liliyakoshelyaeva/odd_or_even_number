using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_or_even
{
    internal class odd_or_even
    {
        public static void Main()
        {
            Console.Write("Введите целое число: ");
            if(int.TryParse(Console.ReadLine(), out int number)) 
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"Число {number} является чётным");
                }
                else
                {
                    Console.WriteLine($"Число {number} является нечётным")
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число");
            }
        }
    }
}
