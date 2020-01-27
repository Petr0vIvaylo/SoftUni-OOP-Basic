using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string aouthor, string title, decimal price)
            : base(aouthor, title, price)
        {

        }

        public override decimal Price
        {
            get
            {
                return base.Price * 1.3m;
            }

        }
    }
}
