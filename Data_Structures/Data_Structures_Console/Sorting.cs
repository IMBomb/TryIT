using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
    class Sorting
    {
        public static int getMax(int [] array, int n)
        {
            int max = array[0];
            for (int i = 1; i < n; i++)
                if (array[i] > max)
                    max = array[i];
            return max;
        }

        // Using counting sort to sort the elements in the basis of significant places
        void countingSort(int []array, int size, int place)
        {
            int [] output = new int[size + 1];
            int max = (array[0] / place) % 10;

            for (int i = 1; i < size; i++)
            {
                if (((array[i] / place) % 10) > max)
                    max = array[i];
            }
            int []count = new int[max + 1];

            for (int i = 0; i < max; ++i)
                count[i] = 0;

            // Calculate count of elements
            for (int i = 0; i < size; i++)
                count[(array[i] / place) % 10]++;

            // Calculate cumulative count
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Place the elements in sorted order
            for (int i = size - 1; i >= 0; i--)
            {
                output[count[(array[i] / place) % 10] - 1] = array[i];
                count[(array[i] / place) % 10]--;
            }

            for (int i = 0; i < size; i++)
                array[i] = output[i];
        }

        // Main function to implement radix sort
        public void radixsort(int []array, int size)
        {
            // Get maximum element
            int max = getMax(array, size);

            // Apply counting sort to sort elements based on place value.
            for (int place = 1; max / place > 0; place *= 10)
                countingSort(array, size, place);
        }

        // Print an array
        public void printArray(int []array, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                Console.WriteLine(array[i].ToString());
            }
            Console.WriteLine("\n");
        }

        public static int CountDigits(int n)
        {
            n = (int)Math.Abs(n); //берем модуль числа
            int count = 0; //заводим счетчик
            if (n == 0) count = 1; // n == 0? Цифра одна.
            while (n != 0) //пока n не равно 0
            {
                n = n / 10; //делим число на 10
                count++; //прибавляем счетчик
            }
            return count;
        }

    }

    class MySort
    {
        public List<int> newList;

        public void DoMySort(int[] array)
        {
            newList = new List<int>(array.Length);
            int max = Sorting.getMax(array, array.Length);
            int DigitsInMax = Sorting.CountDigits(max);
            int place = 1;
            List<int> list = array.ToList();
            for (int i = 1; i <= DigitsInMax; i++)
                place *= 10;
            TenSplit(list, place);

            //foreach(int num in newList)
            //{
            //    Console.WriteLine(num.ToString() + "\n");
            //}
        }

        public void TenSplit(List<int> list, int place)
        {
            if (place > 1)
            {
                place /= 10;

                List<int>[] ThisTen = new List<int>[10];
                int higherPlace = place * 10;

                foreach (int number in list)
                {
                    int CNumber = (number - ((number / (higherPlace)) * higherPlace)) / place;
                    if (ThisTen[CNumber] == null) ThisTen[CNumber] = new List<int>();
                    ThisTen[CNumber].Add(number);
                }
                for (int i = 0; i <= 9; ++i)
                {
                    if (ThisTen[i] != null) TenSplit(ThisTen[i], place);
                }
            }

            else newList.AddRange(list);
        }


        public static int FirstFactorial(int num)
        {
            for (int i = num; i > 1; i--)
            {
                num = num *  (i - 1);
            }
            // code goes here  
            return num;

        }


            public static string StringChallenge(string str)
            {
                string outString = "";

                // code goes here 

                for (int i = 1; i < str.Length; i++)
                {
                    outString += OtherLetter(str[i].ToString(), str[i+1].ToString());

                }
                str = outString;
                return str;

            }

            public static string OtherLetter(string first, string second)
            {
                //string potencialLetters ="abc";
                return "abc".Replace(first, "").Replace(second, "");

            }


        public static int MathChallenge(int num)
        {

            int DigitsInNum = Sorting.CountDigits(num);
            int place = 1;
            int [] digits = new int[DigitsInNum];
            for (int i = 1; i <= DigitsInNum; i++)
            {
                int higherPlace = place * 10;
                int CNumber = (num - ((num / (higherPlace)) * higherPlace)) / place;
                //Console.WriteLine(CNumber.ToString());     
                place = place * 10;
                digits[DigitsInNum - i] = CNumber;
            }
            
            char[] operations = new char[digits.Length-1];
            for(int i = 0; i < digits.Length -1; i++) {
                operations[i] = '0';
            }
            Calculate(digits, operations);
            // code goes here  
            return num;

        }

        public static char[] Calculate(int[] digits, char[] operations) 
        {
            //for()
            int max = 2;
            char[] best_operation;// = new char[operations.Length];
            for (int op = 1;  op < digits.Length - 1; op++)  {
                max *= 2;
            }

            for (int j = 0; j < max; j++)
            {
                string value = Convert.ToString(j, 2);
                for (int y = 0; y < value.Length; y++) {
                    operations[operations.Length - value.Length + y] = value[y];
                }
                string testRes = "";
                foreach (var a in operations) testRes += a.ToString();


                Console.WriteLine("Check" + j + "   " + testRes);
                int result = digits[0];
                for (int d = 1; d < digits.Length; d++)
                {
                    result = DoMath(result, operations[d - 1].ToString(), digits[d]);
                }
                Console.WriteLine(result.ToString());
                //if (result == 0) { foreach (var c in operations( best_operation = operations;
            }
            char[] N = new char[]{ 'N', 'o', 'p', 'e' };
            return N;
        }

        static int  DoMath(int A, string opp, int B)
        {
            int result;
            if (opp == "0") result = A - B;
            else result = A + B;
            return result;
        }
    }

}

