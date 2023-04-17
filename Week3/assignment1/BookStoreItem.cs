namespace assignment1
{
    public abstract class BookStoreItem
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public decimal TotalPrice { get { return Price * Count; } }

        public BookStoreItem(string title, decimal price, int count)
        {
            Title = title;
            Price = price;
            Count = count;
        }

        public abstract void Print();
    }
}
