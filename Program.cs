namespace bookStoreRecord
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore bookstore1 = new(10, "Dune", "Frank Herbert", 21);
            Console.WriteLine(bookstore1);

            Bookstore bookstore2 = new(20, "Dune Messiah", "Frank Herbert", 12);
            Console.WriteLine(bookstore2);

            Bookstore bookstore3 = new(30, "Children of Dune", "Frank Herbert", 9);
            Console.WriteLine(bookstore3);

        }
    }
}