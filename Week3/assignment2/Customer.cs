using System;

namespace assignment2
{
    public class Customer
    {
        private string name;
        private DateTime dayOfBirth;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }
        public DateTime DayOfBirth
        {
            get { return dayOfBirth; }
            set
            {
                if (value < DateTime.Today)
                {
                    dayOfBirth = value;
                }
            }
        }
        public int Age
        {
            get { return (int)((DateTime.Today - DayOfBirth).TotalDays / 365); }
        }

        public bool Discount
        {
            get
            {
                if (Age >= 60)
                {
                    return true;
                }
                return false;
            }
            
        }

        public Customer(string name, DateTime dob)
        {
            Name = name;
            DayOfBirth = dob;
        }
    }
}
