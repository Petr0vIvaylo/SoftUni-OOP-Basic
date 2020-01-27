using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Foods
{
    public abstract class Food
    {
         public Food(int happiness)
        {
            this.Happines = happiness;
        }
        public int Happines { get; }
    }
}
