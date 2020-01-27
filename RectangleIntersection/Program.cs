using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers[0]; i++)
            {
                string[] input = Console.ReadLine().Split();

                string id = input[0];
                double width = double.Parse(input[1]);
                double height = double.Parse(input[2]);
                double x = double.Parse(input[3]);
                double y = double.Parse(input[3]);

                Rectangle rectangle = new Rectangle(id, width, height, x, y);
                rectangles.Add(rectangle);
            }

            for (int j = 0; j < numbers[1]; j++)
            {
                string[] names = Console.ReadLine().Split();

                Rectangle firstRectangle = rectangles.FirstOrDefault(x => x.Id == names[0]);
                Rectangle secondRectangle = rectangles.FirstOrDefault(x => x.Id == names[1]);
                
                if (firstRectangle.Intersect(secondRectangle))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
