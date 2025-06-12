
using three;
internal class Program
{
    private static void Main(string[] args)
    {
        BookShell shell = new BookShell("It Books", new List<Book>()
        {
            new Book("Object Oriented Programming in C++", "Robert Lafore", "Piter", 2024, 800),
            new Book("Grokking Algorithms", "Aditya Bhargava", "Piter", 2024, 300),
            new Book("Code Complete", "Steve McConnell", "PVH", 2025, 900),
            new Book("Code: The Hidden Language of Computer Hardware and Software", "Charles Petzold", "Piter", 2024, 600),
            new Book("Patterns of Object Oriented Programming", "Mark Grand", "Piter", 2024, 500)
        }); // Создание экземпляра класса BookShell с именем "It Books" и списком книг

        shell.PrintShell(); // Печать информации о книжной полке
        Console.WriteLine();
        shell.AddBook(new Book("The Pragmatic Programmer", "Andrew Hunt", "Piter", 2024, 400)); // Добавление новой книги в книжную полку
        shell.PrintShell(); // Печать информации о книжной полке после добавления книги
        Console.WriteLine();

        Book foundBook = shell.SearchByAuthor("Robert Lafore"); // Поиск книги по автору
        shell.RemoveBook(foundBook); // Удаление найденной книги из книжной полки
        shell.PrintShell(); // Печать информации о книжной полке после удаления книги
        Console.WriteLine();

        foundBook = shell.SearchByName("Grokking Algorithms"); // Поиск книги по названию
        shell.RemoveBook(foundBook);
        shell.PrintShell(); // Печать информации о книжной полке после удаления книги
        Console.WriteLine();

    }
}