using System;

namespace Model
{
    public class Reservation
    {
        private int id;
        private DateTime reservationDateTime;
        private Book book;
        private Customer customer;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime ReservationDateTime
        {
            get { return reservationDateTime; }
            set { reservationDateTime = value; }
        }

        public Book Book
        {
            get { return book; }
            set { book = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public Reservation(int id, Customer customer, Book book)
        {
            Id = id;
            Customer = customer;
            Book = book;
        }

        public override string ToString()
        {
            return $"{Customer.ToString()} -> {Book.ToString()}";
        }
    }
}
