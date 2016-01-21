using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class MultipleCheck
    {
        public bool ThreeCheck(int checkNumberThree)
        {
            return checkNumberThree%3 == 0;
        }

        public bool FiveCheck(int checkNumberFive)
        {
            return checkNumberFive%5 == 0;
        }

        public bool AnyCheck(int multiple, int checkNumber)
        {
            return checkNumber % multiple == 0;
        }

        public string checkMultiples(int limit, Dictionary<int, string> dictionary)
        {
            string result = "";
            for (int index = 2; index <= limit;index ++)
            {
                string output = index.ToString();
                foreach (KeyValuePair<int, string> pair in dictionary)
                {
                    if (AnyCheck(pair.Key,index))
                    {
                        output += " " + pair.Value ;
                    }
                }
                result +=output+"\n";
            }
            Debug.WriteLine(result);
            return result;
        }
    }
}