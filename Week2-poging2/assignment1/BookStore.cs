using System.Collections.Generic;
using System;

namespace assignment1
{
    public class BookStore
    {
        private List<BookStoreItem> books = new List<BookStoreItem>();

        public void AddBook(BookStoreItem book)
        {
            books.Add(book);
        }

        public void PrintCompleteStock()
        {
            float total = 0; 
            foreach (BookStoreItem book in books)
            {
                total += book.price;
                book.Print();
            }
            Console.WriteLine("\nTotal sales price: {0}", total.ToString("0.00"));
        }

    }
}
