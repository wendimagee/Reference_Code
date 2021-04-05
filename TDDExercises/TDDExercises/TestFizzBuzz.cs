using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TDDExercises;

namespace TDD
{
    public class TestFizzBuzz
    {
        [Fact]
        public void TestEven()
        {
            //Arrange 
            FizzBuzz fb = new FizzBuzz();

            //Act 
            string actual = fb.OddEvenOrPrime(4);
            string expected = "not a prime";

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestOdd()
        {
            //Arrange 
            FizzBuzz fb = new FizzBuzz();

            //Act 
            string actual = fb.OddEvenOrPrime(5);
            string expected = "prime";

            //Assert
            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void TestRange()
        //{
        //    //Arrange 
        //    FizzBuzz fb = new FizzBuzz();

        //    //Act 
        //    string actual = fb.OddEvenOrPrime(0);
        //    string expected = "error";

        //    //Assert
        //    Assert.Equal(expected, actual);


        //    actual = fb.OddEvenOrPrime(101);
        //    Assert.Equal(expected, actual);
        //}
    }
}
