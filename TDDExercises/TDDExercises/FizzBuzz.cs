using System;
using System.Collections.Generic;
using System.Text;

namespace TDDExercises
{
    public class FizzBuzz
    {
            public string OddEvenOrPrime(int num)
            {
                if (num>1 && num % 2 == 1)
                {
                return "prime";
                }
                else
                {
                    return "error";
                }

            }
        }
    }