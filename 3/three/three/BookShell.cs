using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three
{
    public class BookShell
    {
        private string shellName;
        private List<Book> bookShell;

        public BookShell()
        {
            shellName = "Unknown";
            bookShell = new List<Book>();
        }

        public BookShell(string inShellName, List<Book> inBookShell)
        {
            shellName = inShellName;
            bookShell = inBookShell;
        }


        public Book SearchByAuthor(string authorName)
        {
            if (bookShell.Count != 0) foreach (Book book in bookShell)
                {
                    if (book.GetAuthorName() == authorName)
                    {
                        return book;
                    }
                }
            Console.WriteLine("Book not found");
            return new Book();
        }

        public Book SearchByName(string bookName)
        {
            if (bookShell.Count != 0) foreach (Book book in bookShell)
                {
                    if (book.GetBookName() == bookName)
                    {
                        return book;
                    }
                }
            Console.WriteLine("Book not found");
            return new Book();
        }

        public void AddBook(Book book)
        {
            if (bookShell.Contains(book)) Console.WriteLine("Book already exists in the shell.");
            else bookShell.Add(book);
        }

        public void RemoveBook(Book book)
        {
            if (bookShell.Contains(book)) bookShell.Remove(book);
            else Console.WriteLine("Book not found in the shell.");
        }


        public void PrintShell()
        {
            Console.WriteLine("Shell Name: " + shellName);
            Console.WriteLine("Books in the shell:");
            foreach (Book book in bookShell)
            {
                book.printBookInfo();
            }
        }
    }
}
