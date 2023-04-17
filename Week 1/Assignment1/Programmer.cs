using System;

namespace Assignment1
{
    public class Programmer
    {
        private string name;
        private Specialty specialty;

        public Programmer(string naam) : this(naam, Specialty.Unknown)
        {

        }

        public Programmer(string naam, Specialty specialty)
        {
            this.name = naam;
            this.specialty = specialty;
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}, Specialty: {1}", name, specialty);
        }
    }
}
