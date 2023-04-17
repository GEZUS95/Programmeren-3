namespace Model
{
    public class Customer
    {
        private int id;
        private string email;
        private string firstN;
        private string lastN;
        private string fullN;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string FirstN
        {
            get { return firstN; }
            set { firstN = value; }
        }

        public string LastN
        {
            get { return lastN; }
            set { lastN = value; }
        }
        public string FullN
        {
            get { return fullN; }
            set { fullN = value; }
        }

        public Customer(int id, string firstName, string lastName, string emailAddress)
        {
            Id = id;
            Email = emailAddress;
            FirstN = firstName;
            LastN = lastName;
            FullN = firstName + " " + lastName;
        }

        public override string ToString()
        {
            return $"{FullN} ({Email})";
        }
    }
}
