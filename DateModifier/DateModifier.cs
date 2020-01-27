using System;
using System.Globalization;

namespace DateModifier
{
    public class DateModifier
    {
        
        public static string DaysBetweenTwoDates(string str1, string str2)
        {
            DateTime firstDate = DateTime.Parse(str1);
            DateTime secondDate = DateTime.Parse(str2);
            var result =Math.Abs((secondDate - firstDate).TotalDays);
            return result.ToString();
        }
    }
}
