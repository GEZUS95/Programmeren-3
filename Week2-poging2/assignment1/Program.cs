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
            // your code here...

            Book book1 = new Book("Dracula", "Bram Stoker", 15.00f);
            Book book2 = new Book("Joe speedboot", "Tommy Wieringa", 12.50f);
            Book book3 = new Book("The Hobbit", "J.R.R. Tolkien", 12.50f);

            BookStore store = new BookStore();

            store.AddBook(new Book("Dracula", "Bram Stoker", 15.00f));
            store.AddBook(new Book("Joe speedboot", "Tommy Wieringa", 12.50f));
            store.AddBook(new Magazine("Time", "Friday", 3.90f));
            store.AddBook(new Magazine("Donald Duck", "Thursday", 2.50f));
            store.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 12.50f));

            store.PrintCompleteStock();

            Console.ReadKey();
        }
    }
}
