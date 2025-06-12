using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three
{
    public class Book
    {
        private string bookName;
        private string authorName;
        private string publisherName;
        private int yearPublished;
        private int numberOfPages;

        public Book()
        {
            bookName = "Unknown";
            authorName = "Unknown";
            publisherName = "Unknown";
            yearPublished = 0;
            numberOfPages = 0;
        }

        public Book(string inBookName, string inAuthorName, string inPublisherName, int inYearPublished, int inNumberOfPages)
        {
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

        public string printBookInfo()
        {
            return "Book name:" + bookName + " , " + "Author name:" + authorName + " , " +
                   "Publisher name:" + publisherName + " , " + "Year published:" + yearPublished + " , " +
                   "Number of pages:" + numberOfPages;
        }
    }
}
