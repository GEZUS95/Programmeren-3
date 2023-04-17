namespace assignment1
{
    public abstract class BookStoreItem
    {
        public string title;
        public float price;

        public BookStoreItem(string title, float price)
        {
            this.title = title;
            this.price = price;
        }

        public abstract void Print();
    }
}
