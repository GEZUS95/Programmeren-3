using System.Collections.Generic;
using System;

namespace assignment1
{
    public class BookStore
    {
        private List<BookStoreItem> _items = new List<BookStoreItem>();

        public decimal TotalPrice { get; set; }

        public void AddBook(BookStoreItem item)
        {
            _items.Add(item);
        }

        public void PrintCompleteStock()
        {
            foreach (BookStoreItem item in _items)
            {
                TotalPrice += (item.Count * item.Price);
                item.Print();
            }
            Console.WriteLine("\nTotal sales price: {0}", TotalPrice.ToString("0.00"));
        }

    }
}
