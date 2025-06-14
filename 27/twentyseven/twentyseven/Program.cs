
using twentyseven;
internal class Program
{
    private static void Main(string[] args)
    {
        Reader reader = new Reader("Danil Losev", "email@gmail.com", "+7(999)999-99-99", "Moscow City" );
        BookShell bookShell = new BookShell("My Book Shell", 
            new Book("Book1", "Author1", 100, "Publisher1", "English"), 
            new Book("Book2", "Author2", 200, "Publisher2", "English"),
            new Book("Book3", "Author3", 200, "Publisher3", "English"),
            new Book("Book4", "Author4", 200, "Publisher4", "English"),
            new Book("Book5", "Author5", 100, "Publisher5", "English"),
            new Book("Book6", "Author6", 200, "Publisher6", "English")
            );

        BookShell bookShell1 = new BookShell("My Book Shell 2", 
            new Book("Book7", "Author7", 100, "Publisher7", "English"), 
            new Book("Book8", "Author8", 200, "Publisher8", "English"),
            new Book("Book9", "Author9", 200, "Publisher9", "English"),
            new Book("Book10", "Author10", 200, "Publisher10", "English"),
            new Book("Book11", "Author11", 100, "Publisher11", "English"),
            new Book("Book12", "Author12", 200, "Publisher12", "English")
            );

        Console.WriteLine(bookShell.ToString());

        Console.WriteLine(reader.ToString());

        reader.BringBook(bookShell[0], bookShell);
        reader.BringBook(bookShell[1], bookShell);

        reader.BringBook(bookShell[2], bookShell);
        reader.BringBook(bookShell1[0], bookShell1);

        Console.WriteLine(bookShell.ToString());
        Console.WriteLine(bookShell1.ToString());
        Console.WriteLine(reader.ToString());

        reader.ReturnBook(reader.GetBook(0), bookShell);
        reader.ReturnBook(reader.GetBook(1), bookShell1);

        Console.WriteLine(bookShell.ToString());
        Console.WriteLine(bookShell1.ToString());
        Console.WriteLine(reader.ToString());
    }
}