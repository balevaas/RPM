namespace Lab3Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader r1 = new Reader("Попов А", 362, "Гум", "12-05-12", 789456);
            r1.TakeBook(r1.Person, 5);
            r1.TakeBook(r1.Person, "q", "w", "s");
            Reader r2 = new Reader("qqq", 222, "qqq", "15-55-4", 7777);
            r2.TakeBook(r2.Person, 5);
            r2.TakeBook(r2.Person, "a", "b", "c");
            Book book1 = new Book("fff", "fff");
            Book book2 = new Book("aaa", "aaa");
            Book book3 = new Book("rrr", "rrr");
            Book[] books = new Book[3] { book1, book2, book3 };
            
            Reader r3 = new Reader("vvv", 111, "vvv", "15-4-20", 78453);
            
            for(int i = 0; i < books.Length; i++)
            {
                r3.TakeBook(r3.Person, i);
                Console.WriteLine(books[i]);
            }
        }
    }
}