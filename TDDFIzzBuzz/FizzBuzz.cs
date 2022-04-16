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
            
            string result = (NumbersValidation(numbers)) ? ParseNumbersToString(numbers) : string.Empty;
            return result;
        }

        private string ParseNumbersToString(int[] numbers)
        {
            string result = "";
            
            foreach(var item in numbers)
            {
                if (!CheckIfLastItem(numbers, item))
                    result += CheckNumber(item);
                else result += CheckNumber(item).TrimEnd(',');
            }

            return result;
        }

        private string CheckNumber(int item)
        {
            
            if (item % 3 is 0 || CheckIfContainsThree(item))
                return "Fizz,";
            else if (item % 5 is 0 || CheckIfContainsFive(item))
                return "Buzz,";
            else return item.ToString() + ",";
        }

        private bool CheckIfLastItem(int[] items, int current)
        {
            return current == items[items.Length - 1] ? true : false; 
        }

        private bool CheckIfContainsThree(int item) => item.ToString().Contains("3") ? true : false;
        
        private bool CheckIfContainsFive(int item) => item.ToString().Contains("5") ? true : false;

        private bool NumbersValidation(int[] numbers) => (numbers is null || numbers.Length < 0) ? false : true;
    }
}
