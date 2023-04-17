using System;

namespace assignment1
{
    public class Magazine : BookStoreItem
    {
        private string dayofrelease;

        public Magazine(string title, string dayofrelease, float price) : base(title, price)
        {
            this.dayofrelease = dayofrelease;
        }

        public override void Print()
        {
            Console.WriteLine("[Magazine] {0} - release day: {1}, {2}", base.title, dayofrelease, base.price.ToString("0.00"));
        }
    }
}
