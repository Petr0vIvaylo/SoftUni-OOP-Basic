using System;


namespace DateModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            Console.WriteLine(  DateModifier.DaysBetweenTwoDates(firstDate, secondDate));
        }
    }
}
