using System;

namespace assignment2
{
    public class Ticket
    {
        private string movieName;
        private int cinemaRoom;
        private DateTime startTime;
        private decimal price;
        private int minimumAge;

        public string MovieName
        {
            get { return movieName; }
            set
            {
                try
                {
                    if (value == "")
                    {
                        throw new Exception("Empty movie name!");
                    }

                    movieName = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error occured: {e.Message}");
                }
            }
        }
        public int CinemaRoom
        {
            get { return cinemaRoom; }
            set
            {
                try
                {
                    if ((value <= 0) || (value > 5))
                    {
                        throw new Exception("Invallid cinema room");
                    }

                    cinemaRoom = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error occured: {e.Message} ({value})!");
                }
            }
        }

        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                try
                {
                    if ((value.Minute != 00) && (value.Minute != 30))
                    {
                        throw new Exception("Invallid start time");
                    }

                    startTime = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error occured: {e.Message}! ({value})");
                }
            }

        }

        public decimal Price
        {
            get { return price; }
            private set { this.price = value; }
        }

        public int MinimumAge
        {
            get { return minimumAge; }
            set
            {
                try
                {
                    if ((value != 0) && (value != 6) && (value != 9) && (value != 12) && (value != 16))
                    {
                        throw new Exception("Invallid minumum age");
                    }

                    minimumAge = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error occured: {e.Message} ({value})!");
                }
            }
        }

        public Ticket(string name, decimal price)
        {
            MovieName = name;
            Price = price;
        }

        public bool Discount
        {
            get { return ((StartTime.DayOfWeek == DayOfWeek.Monday)) || (StartTime.DayOfWeek == DayOfWeek.Tuesday); }
        }
    }
}
