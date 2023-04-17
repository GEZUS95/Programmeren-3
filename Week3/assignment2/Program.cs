using System;
using System.Globalization;
using System.Threading;

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
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Customer lionel = new Customer("Lionel Messi", new DateTime(1987, 06, 24));
            Customer piet = new Customer("Piet Paulusma", new DateTime(1956, 12, 15));

            PrintCustomer(lionel);
            PrintCustomer(piet);

            Reservation reservationLionel = new Reservation(lionel);
            Reservation reservationPiet = new Reservation(piet);


            Ticket bohemian = new Ticket("Bohemian Rapsody", 10.50m);
            bohemian.MinimumAge = 6;
            bohemian.CinemaRoom = 1;         
            bohemian.StartTime = new DateTime(2021, 02, 13, 21, 30, 00);

            Ticket prodigy = new Ticket("The Prodigy", 10.50m);
            prodigy.MinimumAge = 16;
            prodigy.CinemaRoom = 4;
            prodigy.StartTime = new DateTime(2021, 02, 13, 22, 00, 00);

            Ticket green = new Ticket("Green Book", 10.50m);
            green.MinimumAge = 12;
            green.CinemaRoom = 5;
            green.StartTime = new DateTime(2021, 02, 15, 19, 00, 00);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"creating tickets (for {lionel.Name})");
            Console.ResetColor();
            reservationLionel.Tickets.Add(bohemian);
            Console.WriteLine($"created ticket '{bohemian.MovieName}', start time: {bohemian.StartTime.ToString("dd/MM/yyyy")} {bohemian.StartTime.Hour}:{bohemian.StartTime.Minute.ToString("00")}, price: {bohemian.Price}, room: {bohemian.CinemaRoom} ({bohemian.MinimumAge}+)");
            reservationLionel.Tickets.Add(prodigy);
            Console.WriteLine($"created ticket '{prodigy.MovieName}', start time: {prodigy.StartTime.ToString("dd/MM/yyyy")} {prodigy.StartTime.Hour}:{prodigy.StartTime.Minute.ToString("00")}, price: {prodigy.Price}, room: {prodigy.CinemaRoom} ({prodigy.MinimumAge}+)");
            reservationLionel.Tickets.Add(green);
            Console.WriteLine($"created ticket '{green.MovieName}', start time: {green.StartTime.ToString("dd/MM/yyyy")} {green.StartTime.Hour}:{green.StartTime.Minute.ToString("00")}, price: {green.Price}, room: {green.CinemaRoom} ({green.MinimumAge}+)");
            Console.WriteLine($"total price of reservation: {reservationLionel.TotalPrice.ToString("0.00")}");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"creating tickets (for {piet.Name})");
            Console.ResetColor();
            reservationPiet.Tickets.Add(bohemian);
            Console.WriteLine($"created ticket '{bohemian.MovieName}', start time: {bohemian.StartTime.ToString("dd/MM/yyyy")} {bohemian.StartTime.Hour}:{bohemian.StartTime.Minute.ToString("00")}, price: {bohemian.Price}, room: {bohemian.CinemaRoom} ({bohemian.MinimumAge}+)");
            reservationPiet.Tickets.Add(prodigy);
            Console.WriteLine($"created ticket '{prodigy.MovieName}', start time: {prodigy.StartTime.ToString("dd/MM/yyyy")} {prodigy.StartTime.Hour}:{prodigy.StartTime.Minute.ToString("00")}, price: {prodigy.Price}, room: {prodigy.CinemaRoom} ({prodigy.MinimumAge}+)");
            reservationPiet.Tickets.Add(green);
            Console.WriteLine($"created ticket '{green.MovieName}', start time: {green.StartTime.ToString("dd/MM/yyyy")} {green.StartTime.Hour}:{green.StartTime.Minute.ToString("00")}, price: {green.Price}, room: {green.CinemaRoom} ({green.MinimumAge}+)");
            Console.WriteLine($"total price of reservation: {reservationPiet.TotalPrice.ToString("0.00")}");

            Console.ReadKey();
        }

        void PrintCustomer(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{customer.Name}");
            Console.ResetColor();
            Console.WriteLine($"date of birth: {customer.DayOfBirth.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"age: {customer.Age}");
            Console.WriteLine("discount: {0}", (customer.Discount ? "yes" : "no"));
            Console.WriteLine();
        }
    }
}
