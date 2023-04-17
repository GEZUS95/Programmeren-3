using Model;
using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        public void Start()
        {
            Customer lMessi = new Customer(1, "Lionel", "Messi", "lionelmessi@hotmail.com");
            Customer dHenley = new Customer(2, "Don", "Henley", "donhenley@gmail.com");

            Book book1 = new Book(1,"Harry Potter and the Prisoner of Azkaban", "J.K. Rowling");
            Book book2 = new Book(2,"The Da Vince Code", "Dan Brown");

            Reservation res1 = new Reservation(1, lMessi, book2);
            Reservation res2 = new Reservation(2, dHenley, book2);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing customers");
            Console.ResetColor();
            Console.WriteLine(lMessi.ToString());
            Console.WriteLine(dHenley.ToString());
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing books");
            Console.ResetColor();
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book2.ToString());
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("testing reservations");
            Console.ResetColor();
            Console.WriteLine(res1.ToString());
            Console.WriteLine(res2.ToString());

            Console.ReadKey();
        }
    }
}
