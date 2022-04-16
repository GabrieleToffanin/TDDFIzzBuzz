using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDFIzzBuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;
        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestCase(new int[] {3}, "Fizz")]
        [TestCase(new int[] {5}, "Buzz")]
        [Test]
        public void GetFizzIfThreeGetBuzzIfFive(int[] num, string expectedResult)
        {
            var result = _fizzBuzz.PrintFizzOrBuzz(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(new int[] {1,2,3,4,5,6}, "1,2,Fizz,4,Buzz,Fizz")]
        [TestCase(new int[] {7,8,9,10,11,12,13}, "7,8,Fizz,Buzz,11,Fizz,Fizz")]
        [Test] 
        public void GetFizzOrBuzzInIntArray(int[] numbers, string expectedResult)
        {
            var result = _fizzBuzz.PrintFizzOrBuzz(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(new int[] {13}, "Fizz")]
        [TestCase(new int[] {512}, "Buzz")]
        [Test]
        public void GetFizzOrBuzzIfContainsToo(int[] numbers, string expectedResult)
        {
            var result = _fizzBuzz.PrintFizzOrBuzz(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
