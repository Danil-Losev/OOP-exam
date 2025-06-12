using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three
{
    public class Book
    {
        private string bookName; // название книги
        private string authorName; // имя автора
        private string publisherName; // имя издателя
        private int yearPublished; // год публикации
        private int numberOfPages; // количество страниц

        public Book() // конструктор по умолчанию
        {
            bookName = "Unknown";
            authorName = "Unknown";
            publisherName = "Unknown";
            yearPublished = 0;
            numberOfPages = 0;
        }

        public Book(string inBookName, string inAuthorName, string inPublisherName, int inYearPublished, int inNumberOfPages)
        {  // конструктор с параметрами
            bookName = inBookName;
            authorName = inAuthorName;
            publisherName = inPublisherName;
            yearPublished = inYearPublished;
            numberOfPages = inNumberOfPages;
        }

        public string GetBookName()
        {
            return bookName;
        }

        public string GetAuthorName()
        {
            return authorName;
        }

        public void printBookInfo()
        {
            Console.WriteLine("--Book name: " + bookName + '\n' + "  Author name: " + authorName + "\n" +
                   "  Publisher name: " + publisherName + '\n' + "  Year published: " + yearPublished + '\n' +
                   "  Number of pages: " + numberOfPages);
        }
    }
}
