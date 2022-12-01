using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
    class OddEven
    {
        int CountOddNumbers(int[] numbers)
        {
            if (numbers.Length == 0)
                numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine($"There are {oddNumbers} odd numbers in {string.Join(" ", numbers)}");
            return oddNumbers;
        }

        public static int find_total(int[] my_numbers)
        {

            int score = 0;
            if (my_numbers != null)
            {
                //int oddNumbers = my_numbers.Count(n => n % 2 == 1);// Ne chetnyi
                //int evenNumbers = my_numbers.Count(n => n % 2 == 0);//Chetnyi
                //int specialNumbers = my_numbers.Count(n => n == 8);
                foreach (int n in my_numbers)
                {
                    if (n % 2 == 1) score += 3;
                    if (n % 2 == 0) score += 1;
                    if (n == 8) score += 4;
                }
                //score = (oddNumbers * 3) + evenNumbers + (specialNumbers * 5) - specialNumbers;
            }
            return score;
        }
    }
}




