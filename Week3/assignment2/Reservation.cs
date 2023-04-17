using System.Collections.Generic;

namespace assignment2
{
    public class Reservation
    {
        private Customer customer;
        private List<Ticket> tickets = new List<Ticket>();

        public Customer Customer
        {
            get { return customer; }
            set { this.customer = value; }
        }

        public List<Ticket> Tickets
        {
            get { return tickets; }
            private set {; }
        }

        public Reservation(Customer customer)
        {
            Customer = customer;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal temp = 0;
                foreach (Ticket ticket in Tickets)
                {
                    if (ticket.Discount)
                    {
                        temp += (ticket.Price * 0.95m);
                    }
                    else
                    {
                        temp += ticket.Price;
                    }
                }
                if (customer.Discount)
                {
                    temp = (temp * 0.9m);
                }

                return temp;
            }
        }

    }
}
