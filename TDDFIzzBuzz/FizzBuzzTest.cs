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
    }
}
