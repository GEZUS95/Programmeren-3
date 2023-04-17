using System;

namespace assignment1
{
    public class Magazine : BookStoreItem
    {
        public string DayOfRelease { get; private set; }

        public Magazine(string title, string dayofrelease, decimal price, int count) : base(title, price, count)
        {
            DayOfRelease = dayofrelease;
        }

        public override void Print()
        {
            Console.WriteLine("[Magazine] {0} - release day: {1}, {2} ({3}x)", base.Title, DayOfRelease, base.Price.ToString("0.00"), base.Count);
        }
    }
}
