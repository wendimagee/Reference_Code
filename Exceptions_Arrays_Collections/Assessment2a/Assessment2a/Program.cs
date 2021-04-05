using System;
using System.Collections.Generic;

namespace EXCEPTIONS_ARRAYS_COLLECTIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wendi!");
            string input = "one";
            string input2 = "two";
            string input3 = "three";
            string[] result = new string[3];
            result = AddValues(input, input2, input3);

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            int[] intArray = new int[3]
            {
               1, 2, 3
            };
            int total = SumArray(intArray);
            Console.WriteLine(total);
            //check removenum
            List<int> intList = new List<int>()
            {
                1, 2, 3, 4, 5, 6
            };
            int intCheck = 3;
            intList = RemoveNum(intList, intCheck);
            foreach(int n in intList)
            {
                Console.WriteLine(n);
            }

        }
        public static string[] AddValues(string input, string input2, string input3)
        {
            string[] result = new string[3]
            {
                input, input2, input3
            };
            return result;
        }
        public static int SumArray(int[] intArray)
        {
            int total = 0;
            foreach (int n in intArray)
            {
                total += n;
            }
            return total;
        }
        public static List<int> RemoveNum(List<int> intList, int intCheck)
        {
            if (intList.Contains(intCheck))
            {
                intList.Remove(intCheck);
                return intList;
            }
            else
            {
                return intList;
            }
        }
        public static List<string> AddToList(string input)
        {
            List<string> stringList = new List<string>();
            stringList.Add("grapes");
            stringList.Add("oranges");
            stringList.Add(input);
            return stringList;
        }
        public static int TryMe(int n, int m)
        {
            try
            {
                int result = n / m;
                return result;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
                return 9;
            }
            catch
            {
                Console.WriteLine("Something went wrong, try again");
                return -1; 
            }
        }
    }
}
