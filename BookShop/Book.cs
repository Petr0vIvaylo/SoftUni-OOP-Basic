using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string aouthor;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value; }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length< 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        public string Author
        {
            get { return aouthor; }
            set
            {
                foreach (var item in value)
                {
                    if (char.IsDigit(item))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                
                aouthor = value;
            }
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;

        }
    }
}
