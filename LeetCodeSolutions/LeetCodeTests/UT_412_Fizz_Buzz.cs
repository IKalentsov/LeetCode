using LeetCodeSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    public class UT_412_Fizz_Buzz
    {
        [Test]
        public void TestSet1()
        {
            var n = 3;

            var result = new List<string>()
            {
                "1","2","Fizz"
            };

            Assert.That(result, Is.EqualTo(FizzBuzz.FizzBuzzSolution(n)));
        }

        [Test]
        public void TestSet2()
        {
            var n = 5;

            var result = new List<string>() 
            {
                "1", "2", "Fizz", "4", "Buzz"
            };

            Assert.That(result, Is.EqualTo(FizzBuzz.FizzBuzzSolution(n)));
        }

        [Test]
        public void TestSet3()
        {
            var n = 15;

            var result = new List<string>()
            {
                "1","2","Fizz","4","Buzz","Fizz","7","8","Fizz",
                "Buzz","11","Fizz","13","14","FizzBuzz"
            };

            Assert.That(result, Is.EqualTo(FizzBuzz.FizzBuzzSolution(n)));
        }
    }
}
