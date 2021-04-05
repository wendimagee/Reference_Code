using System;

namespace Assessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test for first method
            double grade = 33;
            Console.WriteLine(IsPassing(grade));
            //test for second method
            double grade1 = 69;
            double grade2 = 70;
            double grade3 = 68;
            Console.WriteLine(AverageGrades(grade1, grade2, grade3));
            //test for third method
            Console.WriteLine(OddOrEvenAndPassing(grade));
        }
    
        public static bool IsPassing(double grade)
        {
            if (grade > 65)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    
        public static double AverageGrades(double grade1, double grade2, double grade3)
        {
            return (grade1 + grade2 + grade3) / 3;
        }
    
        public static string OddOrEvenAndPassing(double grade)
        {
            if(IsPassing(grade) == true && grade % 2 == 0)
            {
                return "passing and even";
            }
            else if (IsPassing(grade) == true && grade % 2 != 0)
            {
                return "passing and odd";
            }
            else if (IsPassing(grade) == false && grade % 2 == 0)
            {
                return "failing and even";
            }
            else
            {
                return "failing and odd";
            }
        }
    }
}
