using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyseven
{
    public class Reader
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int BooksCount { get; private set; }

        private Dictionary<Book, string> keyValuePairs;
        private List<Book> booksAvailable;

        public Reader(string inName, string inEmail, string inPhone, string inAddress)
        {
            Name = inName;
            Email = inEmail;
            Phone = inPhone;
            Address = inAddress;
            BooksCount = 0;
            keyValuePairs = new Dictionary<Book, string>();
            booksAvailable = new List<Book>();
        }

        public Reader()
        {
            Name = "Unknown";
            Email = "Unknown";
            Phone = "Unknown";
            Address = "Unknown";
            BooksCount = 0;
            keyValuePairs = new Dictionary<Book, string>();
            booksAvailable = new List<Book>();
        }

        public bool BringBook(Book book, BookShell bookShell)
        {
            if (bookShell.RemoveBook(book))
            {
                keyValuePairs.Add(book, bookShell.NameOfShell);
                booksAvailable.Add(book);
                BooksCount++;
                return true;
            }
            else return false;
        }

        public Book GetBook(int index)
        {
            if (index < 0 || index >= booksAvailable.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return booksAvailable[index];
        }

        public bool ReturnBook(Book book, BookShell bookShell)
        {
            if (keyValuePairs.ContainsKey(book) && keyValuePairs[book] == bookShell.NameOfShell)
            {
                keyValuePairs.Remove(book);
                booksAvailable.Remove(book);
                bookShell.AddBook(book);
                BooksCount--;
                return true;
            }
            else
            {
                if (!keyValuePairs.ContainsKey(book)) Console.WriteLine("Book not found in your collection");
                else if (keyValuePairs[book] != bookShell.NameOfShell) Console.WriteLine("Book was on " + keyValuePairs[book] + " shell");
                return false;
            }

        }

        public override string ToString()
        {
            string result = "Reader Name: " + Name + "\nEmail: " + Email +
                            "\nPhone: " + Phone + "\nAddress: " + Address +
                            "\nBooks Count: " + BooksCount + "\nBooks Available:\n";
            foreach (var book in booksAvailable)
            {
                result += book.ToString() + "\n";
            }
            return result;
        }
    }
}
