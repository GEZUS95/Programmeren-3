using System;
using System.Collections.Generic;
using DAL;
using Model;


namespace assignment2
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
            CustomerDAO customerDAO = new CustomerDAO();
            List<Customer> customers = customerDAO.GetAll();

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
            
            Console.WriteLine();
            
            Console.Write("Enter customer id: ");
            int id = int.Parse(Console.ReadLine());

            Customer cust = customerDAO.GetById(id);
            if (cust != null)
            {
                Console.WriteLine(cust.ToString());
            }
            else
            {
                Console.WriteLine("Customer not found");
            }

            Console.WriteLine();


            BookDAO bookDAO = new BookDAO();

            List<Book> books = bookDAO.GetAll();

            foreach (Book b in books)
            {
                Console.WriteLine(b.ToString());
            }

            Console.WriteLine();

            Console.Write("Enter book id: ");
            int bookid = int.Parse(Console.ReadLine());

            Book book = bookDAO.GetById(bookid);
            if (book != null)
            {
                Console.WriteLine(book.ToString());
            }
            else
            {
                Console.WriteLine("Book not found");
            }

        }
    }
}
