using System;

namespace Try_Catch_refactored
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays start at zero index and go up to the last element 
            //What happens when we put an index into an array that's outside its range? 
            string[] colors = { "purple", "blue", "turquoise", "brown", "green", "red", "pink", "magenta" };
            
            int numberInput = GetUserNumber($"Please give me a number between 0 & {colors.Length - 1}!", colors.Length - 1);
            
            Console.WriteLine(colors[numberInput]);
            
            
            //Ask the user if they want to continue here
        }
        
        public static bool VerifyNumberInRange(int maxIndex, int userNumber)
        {
            //Does the user number fall outside the range
            if (userNumber > maxIndex || userNumber < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        
        public static int GetUserNumber(string message, int maxIndex)
        {
            while (true)
            {
                string input = GetUserInput(message);
                try
                {
                    int numberInput = int.Parse(input);
                    
                    bool verifyNumberInRange = VerifyNumberInRange(maxIndex, numberInput);
                    if (verifyNumberInRange == true)
                    {
                        return numberInput;
                    }
                    else
                    {
                        throw new Exception("Number not in the range. ");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect format. " + message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
            
        }
    }
}