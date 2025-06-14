using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyseven
{
    public class BookShell
    {
        private List<Book> booksAvailable;
        public string NameOfShell { get; set; }

        public Book this[int index]
        {
            get
            {
                if (index < 0 || index >= booksAvailable.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return booksAvailable[index];
            }
        }

        public BookShell()
        {
            booksAvailable = new List<Book>();
            NameOfShell = "Unknown";
        }

        public BookShell(string inName, params Book[] books)
        {
            booksAvailable = new List<Book>(books);
            NameOfShell = inName;
        }

        public bool AddBook(Book book)
        {
            booksAvailable.Add(book);
            return true;
        }

        public bool RemoveBook(Book book)
        {
            if (booksAvailable.Contains(book))
            {
                booksAvailable.Remove(book);
                return true;
            }
            else
            {
                Console.WriteLine("Book not found in the collection.");
                return false;
            }
        }

        public override string ToString()
        {
            string result = "Book shell name: " + NameOfShell + "\nBooks Available:\n";
            foreach (var book in booksAvailable)
            {
                result += "  " + book.ToString() + "\n";
            }
            return result;
        }

    }
}
