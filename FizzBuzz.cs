// Write a program that outputs the string representation of numbers from 1 to n.

// But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.

// Example:

// n = 15,

// Return:
// [
//     "1",
//     "2",
//     "Fizz",
//     "4",
//     "Buzz",
//     "Fizz",
//     "7",
//     "8",
//     "Fizz",
//     "Buzz",
//     "11",
//     "Fizz",
//     "13",
//     "14",
//     "FizzBuzz"
// ]
// Subscribe to see which companies asked this question.
using System.Collections.Generic;
partial class FizzBuzz {
    public IList<string> FizzBuzz(int n) {
        IList<string> result = new List<string>();
        int count3 = 1;
        int count5 = 1;
        for(int i = 1; i <= n; ++i)
        {
            if (count3 == 3 && count5 == 5)
            {
                result.Add("FizzBuzz");
                count3 = 1;
                count5 = 1;
            }
            else if(count3 == 3)
            {
                result.Add("Fizz");
                count3 = 1;
                count5++;
            }
            else if(count5 == 5)
            {
                result.Add("Buzz");
                count3++;
                count5 = 1;
            }
            else
            {
                result.Add(System.Convert.ToString(i));
                count3++;
                count5++;
            }
        }
        return result;
    }
}