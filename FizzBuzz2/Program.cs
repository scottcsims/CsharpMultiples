using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
         static void Main(string[] args)
        {

            //limit max is  2,147,483,647 that is, hexadecimal 0x7FFFFFFF.

            var multipleCheck = new MultipleCheck();
            Dictionary<int, string> dictionary =
                new Dictionary<int, string>();

            dictionary.Add(3, "Fizz");
            dictionary.Add(5, "Buzz");
            dictionary.Add(2, "Even");
            multipleCheck.checkMultiples(1000, dictionary);
        }

     
    }
}