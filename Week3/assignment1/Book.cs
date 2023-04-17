using System;

namespace assignment1
{
    public class Book : BookStoreItem
    {
        public string Author { get; private set; }
       
        public Book(string title, string author, decimal price, int count) : base(title, price, count)
        {
            Author = author;
        }

        public override void Print()
        {
            Console.WriteLine("[Book] '{0}' by {1}, {2} ({3}x)", Title, Author, Price.ToString("0.00"), Count);
        }
    }
}
