using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    public class Box
    {
        //parameters length, width and height
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        private double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        private double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

        public void PrintVolume()
        {
            double volume = this.length * this.width * this.height;
            Console.WriteLine($"Volume - {volume:F2}");
        }

        public void PrintSurfaceArea()
        {
            double surfA = 2 * this.length * this.width + 2 * this.width * this.height + 2 * this.height * this.length;
            Console.WriteLine($"Surface Area - {surfA:F2}");
        }

        public void PrintLateralSurfaceArea()
        {
            double lateralArea = 2 * this.length * this.height + 2 * this.width * this.height;
            Console.WriteLine($"Lateral Surface Area - {lateralArea:F2}");
        }

    }
}
