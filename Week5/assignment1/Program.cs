using System;
using Model;
using ReservationSystemLogic;

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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing CustomerService");
            Console.ResetColor();

            Console.WriteLine();

            CustomerService cs = new CustomerService();
            Console.Write("Enter customer id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(cs.GetById(id).ToString()); // get the customer and spit out the data to the console

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing BookService");
            Console.ResetColor();

            Console.WriteLine();

            BookService bs = new BookService();

            Console.Write("Enter name of author: ");
            string noa = Console.ReadLine();

            foreach(Book book in bs.GetByAuthor(noa))
            {
                Console.WriteLine(book.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
