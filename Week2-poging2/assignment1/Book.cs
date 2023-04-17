using System;

namespace assignment1
{
    public class Book : BookStoreItem
    {
        private string author;

        public Book(string title, string author, float price) : base(title, price)
        {
            this.author = author;
        }

        public override void Print()
        {
            Console.WriteLine("[Book] '{0}' by {1}, {2}", title, author, price.ToString("0.00"));
        }
    }
}
