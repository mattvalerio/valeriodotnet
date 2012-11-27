using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Luhn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool x = IsValid("7992739871");

        }

        public static bool IsValid(string cardNumber)
        {
            Func<char, int> parseChar = c => Int32.Parse(c.ToString());
            var sum = cardNumber
                .Select(parseChar)
                .Select((d,i) => (i % 2 == 0) ? d : 2*d)
                .SelectMany(d => d.ToString())
                .Select(parseChar)
                .Sum()
            ;

            return (sum % 10 == 0);
        }

    }

    

}
