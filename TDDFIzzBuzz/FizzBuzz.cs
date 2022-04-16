using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDFIzzBuzz
{
    public class FizzBuzz
    {
        public string PrintFizzOrBuzz(int[] numbers)
        {
            string result = ParseNumbersToString(numbers);
            return result;
        }

        private string ParseNumbersToString(int[] numbers)
        {
            string result = "";
            foreach(var number in numbers)
            {
                if (number.Equals(3))
                    result += "Fizz";
                if (number.Equals(5))
                    result += "Buzz";
            }

            return result;
        }
    }
}
