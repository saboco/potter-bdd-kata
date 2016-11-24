namespace Domain
{
    public class Book
    {
        public decimal Price { get; private set; }
        public object VolumeNumber { get; set; }

        public Book()
        {
            Price = 8.0m;
        }

        public override bool Equals(object obj)
        {
            var book = obj as Book;
            if (book != null == false)
            {
                return base.Equals(obj);
            }
            return book.VolumeNumber == VolumeNumber;
        }

        public override int GetHashCode()
        {
            return VolumeNumber.GetHashCode();
        }
    }
}
