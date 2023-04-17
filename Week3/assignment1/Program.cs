using System;
using System.Globalization;
using System.Threading;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            BookStore store = new BookStore();

            store.AddBook(new Book("Dracula", "Bram Stoker", 15.00m, 5));
            store.AddBook(new Book("Joe speedboot", "Tommy Wieringa", 12.50m, 5));
            store.AddBook(new Magazine("Time", "Friday", 3.90m, 10));
            store.AddBook(new Magazine("Donald Duck", "Thursday", 2.50m, 8));
            store.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 12.50m, 4));

            store.PrintCompleteStock();

            Console.ReadKey();
        }
    }
}
