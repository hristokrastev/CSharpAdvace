using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DateModifier
{
    public class DateModifier
    {

        public static void Diff(string dateOne, string dateTwo)
        {

            var firstDate = DateTime.Parse(dateOne);

            var secondDate = DateTime.Parse(dateTwo);

            TimeSpan difference = firstDate.Subtract(secondDate);

            Console.WriteLine(Math.Abs(difference.TotalDays));
        }
    }
}
