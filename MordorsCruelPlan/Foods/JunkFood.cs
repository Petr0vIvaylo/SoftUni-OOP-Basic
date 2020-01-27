using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Foods
{
    public class JunkFood : Food
    {
        private const int happiness = -1;

        public JunkFood() 
            : base(happiness)
        {
        }
    }
}
